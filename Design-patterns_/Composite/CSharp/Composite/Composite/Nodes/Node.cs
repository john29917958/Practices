using System.IO;
using Composite.Visitors;

namespace Composite.Nodes
{
    public abstract class Node
    {
        public abstract Node[] Children { get; }

        public string Path
        {
            get => _path;
            set
            {
                if (!System.IO.File.Exists(value) && !System.IO.Directory.Exists(value))
                {
                    throw new FileNotFoundException("The file " + value + " does not exist");
                }

                _path = value;
            }
        }

        private string _path;

        protected Node(string path)
        {
            Path = path;
        }

        public abstract void Accept(Visitor visitor);

        public abstract void Execute();

        public virtual void Add(Node node)
        {

        }

        public virtual void Remove(Node node)
        {

        }
    }
}