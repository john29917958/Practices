using System.Collections.Generic;
using Composite.Nodes;

namespace Composite.Visitors
{
    public class SearchVisitor : Visitor
    {
        public string Path { get; }

        public Node[] Results => _results.ToArray();

        private readonly List<Node> _results;

        public SearchVisitor(string path)
        {
            Path = path;
            _results = new List<Node>();
        }

        public override void Visit(Node node)
        {
            if (node.Path == Path)
            {
                _results.Add(node);
            }
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