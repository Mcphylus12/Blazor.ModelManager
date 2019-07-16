using Manager;
using Microsoft.AspNetCore.Components;
using Models;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Site.Client.Managers
{
    public class WeatherForecastManager : ModelRequestManager
    {
        private readonly HttpClient http;
        private CancellationTokenSource _cancellationToken;

        public WeatherForecastManager(IModelStorer modelStorer, HttpClient http)
            : base(modelStorer)
        {
            _cancellationToken = new CancellationTokenSource();
            this.http = http;
        }

        private async Task OnPollAsync()
        {
            WeatherForecast[] forecasts = await http.GetJsonAsync<WeatherForecast[]>("api/SampleData/WeatherForecasts").ConfigureAwait(false);

            foreach (var forecast in forecasts)
            {
                ModelStorer.StoreModel(forecast.Id, forecast);
            }
        }

        protected override async Task OnKeysUpdated()
        {
            if (Keys.Count == 0)
            {
                _cancellationToken.Cancel();
                _cancellationToken = new CancellationTokenSource();
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
                    await Task.Delay(5000, cancellationToken);
                    if (cancellationToken.IsCancellationRequested)
                        break;
                }
            });
        }
    }
}
