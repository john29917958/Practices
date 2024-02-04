using System;
using Observer.Observers;
using Observer.Subjects;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Character enemy = new Character
            {
                Name = "John",
                Race = Races.Elf,
                X = 0,
                Y = 100,
                Hp = 100,
                Mana = 100
            };

            HitCountUi hitCountUi = new HitCountUi();
            EventCenter.FindSubject<HitEnemySubject>().Attach(hitCountUi.OnEnemyHit);
            EventCenter.FindSubject<HitEnemySubject>().Attach(new RaceHitCountAchievement(Races.Elf, 3).OnEnemyHit);
            EventCenter.FindSubject<KillEnemySubject>().Attach(new FirstBloodAchievement().OnEnemyKilled);

            enemy.Hp -= 10;
            EventCenter.FindSubject<HitEnemySubject>().Notify(enemy);
            Console.WriteLine("============================");

            enemy.Hp -= 10;
            EventCenter.FindSubject<HitEnemySubject>().Notify(enemy);
            Console.WriteLine("============================");

            enemy.Hp -= 10;
            EventCenter.FindSubject<HitEnemySubject>().Notify(enemy);
            Console.WriteLine("============================");

            enemy.Hp = 0;
            EventCenter.FindSubject<HitEnemySubject>().Notify(enemy);
            EventCenter.FindSubject<KillEnemySubject>().Notify(enemy);
            Console.WriteLine("============================");

            Console.ReadLine();
        }
    }
}
