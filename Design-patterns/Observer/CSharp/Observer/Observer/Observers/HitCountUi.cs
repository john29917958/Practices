using System;
using Observer.Subjects;

namespace Observer.Observers
{
    public class HitCountUi
    {
        public void OnEnemyHit(HitEnemySubject subject)
        {
            Console.WriteLine("Hit Count UI: " + subject.TotalHitCount);
        }
    }
}