namespace ChainOfResponsibility.Handlers
{
    public abstract class Handler
    {
        public string Name { get; protected set; }

        public abstract bool PassToNextOnSuccess { get; }

        public abstract bool IsApplicable { get; }

        public Requests Request { get; }

        protected Handler(Requests request)
        {
            Request = request;
        }

        public abstract bool Handle();
    }
}