namespace Memento
{
    public interface ISerializable<TMemento>
    {
        TMemento Export();
        void Import(TMemento memento);
    }
}