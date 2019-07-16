using System.Collections.ObjectModel;

namespace Site.Client.Layout
{
    public class LayoutNode : Collection<ILayoutNode>, ILayoutNode
    {
        public void Visit(ILayoutBuilder builder)
        {
            using (builder.OpenDiv())
            {
                foreach (ILayoutNode node in this)
                {
                    node.Visit(builder);
                }
            }
        }
    }
}
