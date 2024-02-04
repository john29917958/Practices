using System.Collections.Generic;
using System.Linq;

namespace Observer.Subjects
{
    public class HitEnemySubject : Subject<Character, HitEnemySubject>
    {
        public Character Victim { get; private set; }

        public IReadOnlyDictionary<Character, int> EnemyHitCounts => _enemyHitCounts;

        public int TotalHitCount => EnemyHitCounts.Select(pair => pair.Value).Sum();

        private readonly Dictionary<Character, int> _enemyHitCounts;

        public HitEnemySubject()
        {
            _enemyHitCounts = new Dictionary<Character, int>();
        }

        public override void Notify(Character info)
        {
            Victim = info;

            if (_enemyHitCounts.ContainsKey(info))
            {
                _enemyHitCounts[info] += 1;
            }
            else
            {
                _enemyHitCounts.Add(info, 1);
            }

            Observers?.Invoke(this);
        }
    }
}