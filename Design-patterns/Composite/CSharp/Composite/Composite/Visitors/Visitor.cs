using Composite.Nodes;

namespace Composite.Visitors
{
    public abstract class Visitor
    {
        public virtual void Visit(Node node)
        {

        }

        public virtual void VisitFile(File file)
        {

        }

        public virtual void VisitDirectory(Directory directory)
        {

        }
    }
}