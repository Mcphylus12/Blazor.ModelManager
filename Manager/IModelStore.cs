using System;

namespace Manager
{
    internal interface IModelStore
    {
        void RemoveHandler(string key, Action<object> listener);

        void AddHandler(string key, Action<object> listener);

        void UpdateModel(string key, object model);
    }
}