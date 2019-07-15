using Manager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelManager.Managers
{
    public abstract class ModelRequestManager : IModelRequestManager
    {
        private readonly Dictionary<string, int> interestCount;
        protected readonly IModelStorer ModelStorer;
        protected readonly HashSet<string> Keys;

        public ModelRequestManager(IModelStorer modelStorer)
        {
            this.ModelStorer = modelStorer;
            interestCount = new Dictionary<string, int>();
            Keys = new HashSet<string>();
        }

        public void AddInterest(string key)
        {
            if (interestCount.ContainsKey(key))
            {
                interestCount[key]++;
            }
            else
            {
                interestCount.Add(key, 1);
            }

            if (interestCount[key] == 1)
            {
                Keys.Add(key);
            }

            OnKeysUpdatedAsync();
        }

        public void RemoveInterest(string key)
        {
            interestCount[key]--;

            if (interestCount[key] == 0)
            {
                Keys.Remove(key);
            }

            OnKeysUpdatedAsync();
        }

        protected abstract Task OnKeysUpdatedAsync();
    }
}
