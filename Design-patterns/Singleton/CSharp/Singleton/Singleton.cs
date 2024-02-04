namespace Singleton
{
    public class Singleton
    {
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

        private static Singleton _instance;

        private object _data;

        private Singleton()
        {
            _data = new object();
        }

        public void Operation()
        {

        }

        public object GetData()
        {
            return _data;
        }
    }
}
