using Microsoft.AspNetCore.Components;
using System;

namespace Site.Client.Layout
{
    public interface ILayoutBuilder
    {
        IDisposable OpenDiv();

        IDisposable OpenComponent<T>()
            where T : ComponentBase;

        void AddAttribute(string v, string componentKey);
    }
}