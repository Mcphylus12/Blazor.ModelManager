using System.Threading.Tasks;
using Manager;
using Site.Client.Layout;
using Site.Client.Shared;

namespace Site.Client.Managers
{
    public class LayoutManager : ModelRequestManager
    {
        public LayoutManager(IModelStorer modelStorer) 
            : base(modelStorer)
        {
        }

        protected override Task OnKeysUpdated()
        {
            ModelStorer.StoreModel("MainLayout", new LayoutNode
            {
                new ComponentNode<WeatherForecastView>("1"),
                new ComponentNode<WeatherForecastView>("2")
            });

            return Task.CompletedTask;
        }
    }
}
