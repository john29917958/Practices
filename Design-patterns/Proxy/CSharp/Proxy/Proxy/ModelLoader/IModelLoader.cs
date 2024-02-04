namespace Proxy.ModelLoader
{
    public interface IModelLoader
    {
        void LoadToGameObject(GameObject gameObject, string modelName);
    }
}