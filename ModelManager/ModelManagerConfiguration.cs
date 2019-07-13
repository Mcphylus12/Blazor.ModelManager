using Manager;
using ModelManager.Managers;
using Models;

namespace ModelManager
{
    internal class ModelManagerConfiguration : IModelManagerConfiguration
    {
        public void RegisterManagers(IModelManagerRegister register)
        {
            register.RegisterModelManager<WeatherForecastModel, WeatherForecastManager>();
        }

        public void RegisterStoreOverrides(IModelStoreRegister storeRegister)
        {

        }
    }
}