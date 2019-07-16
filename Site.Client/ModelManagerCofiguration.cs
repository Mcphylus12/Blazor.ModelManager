using Manager;
using Models;
using Site.Client.Layout;
using Site.Client.Managers;

namespace Site.Client
{
    public class ModelManagerCofiguration : IModelManagerConfiguration
    {
        public void RegisterManagers(IModelManagerRegister register)
        {
            register.RegisterModelManager<WeatherForecast, WeatherForecastManager>();
            register.RegisterModelManager<LayoutNode, LayoutManager>();
        }

        public void RegisterStoreOverrides(IModelStoreRegister storeRegister)
        {

        }
    }
}