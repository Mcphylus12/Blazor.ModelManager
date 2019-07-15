using Manager;
using ModelManager.Managers;

namespace Site.Shared
{
    public class ModelManagerCofiguration : IModelManagerConfiguration
    {
        public void RegisterManagers(IModelManagerRegister register)
        {
            register.RegisterModelManager<WeatherForecast, WeatherForecastManager>();
        }

        public void RegisterStoreOverrides(IModelStoreRegister storeRegister)
        {

        }
    }
}