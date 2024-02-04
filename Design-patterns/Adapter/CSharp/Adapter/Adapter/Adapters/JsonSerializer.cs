using Adapter.ExternalLibraries;

namespace Adapter.Adapters
{
    public class JsonSerializer : ISerializer
    {
        public string Serialize(object obj)
        {
            JsonUtil library = new JsonUtil();
            string text = library.Serialize(obj);
            return text;
        }
    }
}