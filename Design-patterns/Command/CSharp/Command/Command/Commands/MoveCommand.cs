namespace Command.Commands
{
    public class MoveCommand : Command
    {
        public int X { get; }

        public int Y { get; }

        private readonly Character _character;

        private int _originX;

        private int _originY;

        public MoveCommand(int x, int y, Character character)
        {
            Name = "Move";
            X = x;
            Y = y;
            _character = character;
        }

        protected override void DoExecute()
        {
            _originX = _character.Row;
            _originY = _character.Column;

            _character.Row = X;
            _character.Column = Y;
        }

        protected override void UndoExecution()
        {
            _character.Row = _originX;
            _character.Column = _originY;
        }
    }
}