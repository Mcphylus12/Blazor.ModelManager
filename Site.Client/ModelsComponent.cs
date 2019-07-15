using Manager;
using Microsoft.AspNetCore.Components;
using System;

namespace ModelManager.Components
{
    public class ModelsComponent<T> : ComponentBase, IObserver<T>
        where T : class
    {
        [Inject]
        private IModelProvider modelProvider { get; set; }

        [Parameter]
        private string Key { get; set; }

        protected T DataModel { get; set; }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(T value)
        {
            DataModel = value;
            base.StateHasChanged();
        }

        protected override void OnInit()
        {
            base.OnInit();

            var handle = modelProvider.RequestHandle<T>();

            handle.UpdateKey(Key);

            handle.Subscribe(this);
        }
    }
}
