namespace Observer.Subjects
{
    public delegate void NotifyInterface<T>(T args);

    public abstract class Subject<TReceiveArgs, TNotifyArgs> where TNotifyArgs : Subject<TReceiveArgs, TNotifyArgs>
    {
        protected NotifyInterface<TNotifyArgs> Observers;

        public void Attach(NotifyInterface<TNotifyArgs> notifyInterface)
        {
            Observers += notifyInterface;
        }

        public void Detach(NotifyInterface<TNotifyArgs> notifyInterface)
        {
            Observers -= notifyInterface;
        }

        public abstract void Notify(TReceiveArgs info);
    }
}