using System.Threading;

namespace Proxy.ModelLoader
{
    public class RealLoader : IModelLoader
    {
        private GameObject _gameObject;
        private string _modelName;

        public void LoadToGameObject(GameObject gameObject, string modelName)
        {
            _gameObject = gameObject;
            _modelName = modelName;
            new Thread(Loaded).Start();
        }

        private void Loaded()
        {
            Thread.Sleep(500);
            _gameObject.Model = new Model(_modelName);
        }
    }
}