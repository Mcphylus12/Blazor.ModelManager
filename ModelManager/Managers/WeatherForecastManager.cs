using Manager;
using Microsoft.AspNetCore.Components;
using Models;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ModelManager.Managers
{
    public class WeatherForecastManager : ModelRequestManager
    {
        private readonly HttpClient http;
        private CancellationTokenSource _cancellationToken;

        public WeatherForecastManager(IModelStorer modelStorer, HttpClient http) 
            : base(modelStorer)
        {
            this.http = http;
        }

        private async Task OnPollAsync()
        {
            WeatherForecastModel[] forecasts = await http.GetJsonAsync<WeatherForecastModel[]>("sample-data/weather.json");

            foreach (var forecast in forecasts)
            {
                ModelStorer.StoreModel(forecast.Date.ToString(), forecast);
            }
        }

        protected override async Task OnKeysUpdatedAsync()
        {
            if (Keys.Count == 0)
            {
                _cancellationToken.Cancel();
            }

            if (Keys.Count == 1)
            {
                await StartPolling(_cancellationToken.Token);
            }
        }

        public async Task StartPolling(CancellationToken cancellationToken)
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    await OnPollAsync();
                    await Task.Delay(10000, cancellationToken);
                    if (cancellationToken.IsCancellationRequested)
                        break;
                }
            });

        }
    }
}
