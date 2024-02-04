using System;
using System.Threading;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character("Memento Rocks!");
            CharacterCaretaker caretaker = new CharacterCaretaker(character);
            DateTime rollbackTime = caretaker.Snapshot();
            Console.WriteLine(character + Environment.NewLine + "==========================");

            Thread.Sleep(100);

            character.MoveTo(50, 100);
            caretaker.Snapshot();
            Console.WriteLine(character + Environment.NewLine + "==========================");

            Thread.Sleep(100);

            character.TakeDamage(30);
            caretaker.Snapshot();
            Console.WriteLine(character + Environment.NewLine + "==========================");

            Thread.Sleep(100);

            character.Cure(10);
            caretaker.Snapshot();
            Console.WriteLine(character + Environment.NewLine + "==========================");

            caretaker.Rollback(rollbackTime);
            Console.WriteLine(character + Environment.NewLine + "==========================");

            Console.ReadLine();
        }
    }
}
