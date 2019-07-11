using System;

namespace Manager
{
    public interface IModelHandle<T> : IObservable<T>
    {
        void UpdateKey(string Id);
    }
}