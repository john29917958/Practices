using Adapter.ExternalLibraries;

namespace Adapter.Adapters
{
    public class TextSerializer : ISerializer
    {
        public string Serialize(object obj)
        {
            ObjToTextLibrary library = new ObjToTextLibrary(obj);
            string text = library.Convert();
            return text;
        }
    }
}