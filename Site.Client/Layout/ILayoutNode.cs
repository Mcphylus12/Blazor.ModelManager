using Microsoft.AspNetCore.Components.RenderTree;

namespace Site.Client.Layout
{
    public interface ILayoutNode
    {
        void Visit(ILayoutBuilder builder);
    }
}