using System.Collections.Generic;

namespace Command.Commands
{
    public class CreateCommand : Command
    {
        public readonly string CharacterName;
        public readonly int InitialRow;
        public readonly int InitialColumn;

        private readonly List<Character> _characters;
        private Character _generatedCharacter;

        public CreateCommand(List<Character> characters, string name, int initialRow = 0, int initialColumn = 0)
        {
            Name = "Create";
            CharacterName = name;
            InitialRow = initialRow;
            InitialColumn = initialColumn;
            _characters = characters;
        }

        protected override void DoExecute()
        {
            _generatedCharacter = new Character
            {
                Name = CharacterName,
                Row = InitialRow,
                Column = InitialColumn,
                Health = 100,
                Mana = 100
            };

            _characters.Add(_generatedCharacter);
        }

        protected override void UndoExecution()
        {
            _characters.Remove(_generatedCharacter);
        }
    }
}