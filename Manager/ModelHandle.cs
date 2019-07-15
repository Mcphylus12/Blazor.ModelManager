using System;

namespace Manager
{
    internal class ModelHandle<T> : IModelHandle<T>, IDisposable
        where T : class
    {
        private IModelRequestManager _manager;
        private readonly IModelStore _modelStore;
        private string _currentKey;
        private IObserver<T> _modelObserver;

        public ModelHandle(IModelRequestManager manager, IModelStore modelStore)
        {
            this._manager = manager;
            this._modelStore = modelStore;
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            this._modelObserver = observer;
            return this;
        }

        public void UpdateKey(string newKey)
        {
            UpdateRequestManager(newKey);

            UpdateModelStore(newKey);

            _currentKey = newKey;
        }

        private void UpdateModelStore(string newKey)
        {
            if (_currentKey != null)
            {
                _modelStore.RemoveHandler(_currentKey, HandleModelUpdated);
            }

            _modelStore.AddHandler(newKey, HandleModelUpdated);
        }

        private void UpdateRequestManager(string newKey)
        {
            if (_currentKey != null)
            {
                _manager.RemoveInterest(_currentKey);
            }
            _manager.AddInterest(newKey);
        }

        private void HandleModelUpdated(object obj)
        {
            _modelObserver.OnNext(obj as T);
        }

        public void Dispose()
        {
            _manager.RemoveInterest(_currentKey);
            _modelStore.RemoveHandler(_currentKey, HandleModelUpdated);

            _modelObserver.OnCompleted();
        }
    }
}