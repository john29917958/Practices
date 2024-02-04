namespace Command.Commands
{
    public abstract class Command
    {
        public string Name;

        public bool IsExecuted { get; private set; }

        public void Execute()
        {
            DoExecute();
            IsExecuted = true;
        }

        public void Undo()
        {
            UndoExecution();
            IsExecuted = false;
        }

        protected abstract void DoExecute();

        protected abstract void UndoExecution();
    }
}