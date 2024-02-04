using System;
using Observer.Subjects;

namespace Observer.Observers
{
    public class FirstBloodAchievement
    {
        public bool IsAchieved { get; private set; }

        public void OnEnemyKilled(KillEnemySubject subject)
        {
            if (IsAchieved) return;

            Console.WriteLine("Achievement reached: First blood!");
            IsAchieved = true;
        }
    }
}