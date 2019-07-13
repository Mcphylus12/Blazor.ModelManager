﻿using System;
using System.Collections.Generic;

namespace Manager
{
    internal class ModelStore : IModelStore
    {
        private Dictionary<string, HashSet<Action<object>>> listeners;
        private Dictionary<string, object> models;

        public ModelStore()
        {
            listeners = new Dictionary<string, HashSet<Action<object>>>();
        }

        public void AddHandler(string key, Action<object> listener)
        {
            listeners[key].Add(listener);
        }

        public void RemoveHandler(string key, Action<object> listener)
        {
            listeners[key].Remove(listener);
        }

        public void UpdateModel(string key, object model)
        {
            models[key] = model;

            foreach (var listener in listeners[key])
            {
                listener.Invoke(model);
            }
        }
    }
}