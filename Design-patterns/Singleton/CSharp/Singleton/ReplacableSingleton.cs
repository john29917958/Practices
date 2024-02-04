using System.Diagnostics;

namespace Singleton
{
    public class ReplacableSingleton
    {
        private object _data;

        public ReplacableSingleton()
        {
            _data = new object();
        }

        public virtual void Operation()
        {
            Debug.WriteLine("Replacable singleton");
        }

        public object GetData()
        {
            return _data;
        }
    }
}