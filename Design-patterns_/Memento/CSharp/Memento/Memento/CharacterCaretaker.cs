using System;
using System.Collections;
using System.Collections.Specialized;

namespace Memento
{
    public class CharacterCaretaker
    {
        private readonly Character _character;
        private readonly OrderedDictionary _snapshots;

        public CharacterCaretaker(Character character)
        {
            _character = character;
            _snapshots = new OrderedDictionary();
        }

        public DateTime Snapshot()
        {
            DateTime rollbackTime = DateTime.Now;
            CharacterMemento memento = _character.Export();
            _snapshots.Insert(0, rollbackTime, memento);
            return rollbackTime;
        }

        public void Rollback(DateTime snapshotTime)
        {
            CharacterMemento targetMemento = null;

            foreach (DictionaryEntry snapshot in _snapshots)
            {
                DateTime time = (DateTime) snapshot.Key;
                CharacterMemento memento = (CharacterMemento) snapshot.Value;

                if (time <= snapshotTime) targetMemento = memento;
            }

            if (targetMemento != null)
            {
                _character.Import(targetMemento);
            }
        }
    }
}