using System.Threading.Tasks;
using Manager;
using Site.Client.List;

namespace Site.Client.Managers
{
    public class ListManager : ModelRequestManager
    {
        public ListManager(IModelStorer modelStorer) 
            : base(modelStorer)
        {
        }

        protected override Task OnKeysUpdated()
        {
            ListModel list = new ListModel("MainList");

            list.Source = 

            ModelStorer.StoreModel(list.Id, list);

            return Task.CompletedTask;
        }
    }
}
