using System;
using Observer.Subjects;

namespace Observer.Observers
{
    public class RaceHitCountAchievement
    {
        public bool IsAchieved { get; private set; }

        public Races Race { get; private set; }

        public int TargetCount { get; private set; }

        public int CurrentCount { get; private set; }

        public RaceHitCountAchievement(Races race, int targetCount)
        {
            Race = race;
            TargetCount = targetCount;
            IsAchieved = false;
        }

        public void OnEnemyHit(HitEnemySubject subject)
        {
            if (IsAchieved) return;

            if (subject.Victim.Race == Race)
            {
                CurrentCount += 1;
            }

            if (CurrentCount >= TargetCount)
            {
                IsAchieved = true;
                Console.WriteLine("Achievement reached: RaceHitCountAchievement");
            }
        }
    }
}