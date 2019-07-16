using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;
using System;

namespace Site.Client.Layout
{
    public class RenderTreeLayoutBuilder : ILayoutBuilder
    {
        private const string DIV = "div";
        private readonly RenderTreeBuilder builder;
        private int sequenceCounter;

        public RenderTreeLayoutBuilder(RenderTreeBuilder builder)
        {
            this.builder = builder;
        }

        public void AddAttribute(string key, string value)
        {
            builder.AddAttribute(sequenceCounter++, key, value);
        }

        public IDisposable OpenComponent<T>()
            where T : ComponentBase
        {
            builder.OpenComponent<T>(sequenceCounter++);

            return new Closer(builder.CloseComponent);
        }

        public IDisposable OpenDiv()
        {
            builder.OpenElement(sequenceCounter++, DIV);

            return new Closer(builder.CloseElement);
        }
    }

    internal class Closer : IDisposable
    {
        private readonly Action closeAction;

        public Closer(Action CloseAction)
        {
            closeAction = CloseAction;
        }

        public void Dispose()
        {
            closeAction();
        }
    }
}
