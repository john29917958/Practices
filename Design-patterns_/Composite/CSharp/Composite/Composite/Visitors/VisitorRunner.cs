using Composite.Nodes;

namespace Composite.Visitors
{
    public static class VisitorRunner
    {
        public static void Run(Node node, Visitor visitor)
        {
            node.Accept(visitor);

            foreach (Node child in node.Children)
            {
                Run(child, visitor);
            }
        }
    }
}