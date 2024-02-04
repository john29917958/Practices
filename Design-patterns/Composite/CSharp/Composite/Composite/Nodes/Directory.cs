using System.Collections.Generic;
using System.Diagnostics;
using Composite.Visitors;

namespace Composite.Nodes
{
    public class Directory : Node
    {
        public override Node[] Children => _children.ToArray();

        private readonly List<Node> _children;

        public Directory(string path) : base(path)
        {
            _children = new List<Node>();
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitDirectory(this);
        }

        public override void Execute()
        {
            Process.Start("explorer.exe", Path);
        }

        public override void Add(Node node)
        {
            _children.Add(node);
        }

        public override void Remove(Node node)
        {
            _children.Remove(node);
        }
    }
}