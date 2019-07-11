using Manager;
using Microsoft.AspNetCore.Components;
using Models;
using System;

namespace ModelManager.Components
{
    public class ModelsComponent<T> : ComponentBase, IObserver<T>
        where T : class
    {
        [Inject]
        private IModelProvider modelProvider { get; set; }

        protected T Model { get; set; }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(T value)
        {
            Model = value;
        }

        protected override void OnInit()
        {
            base.OnInit();

            var handle = modelProvider.RequestHandle<T>();

            handle.UpdateKey("Summer");

            handle.Subscribe(this);
        }
    }
}
