using System;
using Composite.Nodes;

namespace Composite.Visitors
{
    public class PrintVisitor : Visitor
    {
        public override void Visit(Node node)
        {
            Console.WriteLine("Print node: " + node.Path);
        }

        public override void VisitFile(File file)
        {
            Visit(file);
        }

        public override void VisitDirectory(Directory directory)
        {
            Visit(directory);
        }
    }
}