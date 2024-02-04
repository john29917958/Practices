namespace Proxy.ModelLoader
{
    public class ProxyLoader : IModelLoader
    {
        private string _modelName;
        private readonly RealLoader _loader;
        private GameObject _gameObject;

        public ProxyLoader(RealLoader loader)
        {
            _loader = loader;
        }

        public void LoadToGameObject(GameObject gameObject, string modelName)
        {
            _gameObject = gameObject;
            _modelName = modelName;
            Model model = new Model(modelName + " - preview version");
            _gameObject.Model = model;

            _loader.LoadToGameObject(_gameObject, _modelName);
        }
    }
}