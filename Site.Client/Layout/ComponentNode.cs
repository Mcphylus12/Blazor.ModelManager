using Microsoft.AspNetCore.Components;

namespace Site.Client.Layout
{
    public class ComponentNode<TComponent> : ILayoutNode
        where TComponent : ComponentBase
    {
        private const string KeyAttribute = "Key";
        private readonly string componentKey;

        public ComponentNode(string componentKey)
        {
            this.componentKey = componentKey;
        }

        public void Visit(ILayoutBuilder builder)
        {
            using (builder.OpenComponent<TComponent>())
            {
                builder.AddAttribute(KeyAttribute, componentKey);
            }
        }
    }
}
