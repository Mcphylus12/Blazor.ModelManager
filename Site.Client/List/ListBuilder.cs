using Microsoft.AspNetCore.Components.RenderTree;

namespace Site.Client.List
{
    public class ListBuilder
    {
        private readonly RenderTreeBuilder builder;

        public ListBuilder(RenderTreeBuilder builder)
        {
            this.builder = builder;
        }

        public void Build(ListModel model)
        {

        }
    }
}
