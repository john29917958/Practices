namespace Observer.Subjects
{
    public class KillEnemySubject : Subject<Character, KillEnemySubject>
    {
        public override void Notify(Character info)
        {
            Observers?.Invoke(this);
        }
    }
}