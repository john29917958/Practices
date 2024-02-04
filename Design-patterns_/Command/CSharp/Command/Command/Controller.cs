using System;
using System.Collections.Generic;
using Command.Commands;
using Newtonsoft.Json;

namespace Command
{
    public class Controller
    {
        public int Head { get; private set; }

        public ICharacterAttributes[] Characters => _characters.ToArray();

        private readonly List<Character> _characters;
        private readonly List<Commands.Command> _commands;

        public Controller()
        {
            Head = 0;
            _characters = new List<Character>();
            _commands = new List<Commands.Command>();
        }

        public void AddMoveToCommand(ICharacterAttributes character, int row, int column)
        {
            Character c = _characters.Find(character1 => character1 == character);
            _commands.Add(new MoveCommand(row, column, c));
        }

        public void AddCreateCommand(string name, int initialRow = 0, int initialColumn = 0)
        {
            _commands.Add(new CreateCommand(_characters, name, initialRow, initialColumn));
        }

        public void ExecuteNext()
        {
            if (_commands.Count == 0 || Head >= _commands.Count) return;
            if (Head == -1) Head = 0;

            Commands.Command command = _commands[Head];
            command.Execute();
            Head += 1;
        }

        public void Undo()
        {
            if (_commands.Count == 0 || Head <= 0) return;

            Head -= 1;
            Commands.Command command = _commands[Head];
            command.Undo();
        }

        public void CancelLast()
        {
            if (_commands.Count == 0 || Head < 0) return;
            if (_commands[Head].IsExecuted) return;

            _commands.RemoveAt(Head);
            Head -= 1;
        }

        public override string ToString()
        {
            string commands = JsonConvert.SerializeObject(_commands, Formatting.Indented);
            string characters = JsonConvert.SerializeObject(_characters, Formatting.Indented);

            string output = "Commands:" + Environment.NewLine + commands + Environment.NewLine +
                            "Characters:" + Environment.NewLine + characters;

            return output;
        }
    }
}