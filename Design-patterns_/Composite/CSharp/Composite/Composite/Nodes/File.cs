using System.Diagnostics;
using Composite.Visitors;

namespace Composite.Nodes
{
    public class File : Node
    {
        public override Node[] Children => new Node[0];

        public File(string path) : base(path)
        {

        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitFile(this);
        }

        public override void Execute()
        {
            Process.Start(Path);
        }
    }
}