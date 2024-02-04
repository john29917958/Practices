namespace Factory.Characters.Enemies
{
    public enum Enemies { Spider, Ghost, Satan }

    public interface IEnemy
    {
        void SetHp(int hp);
        void SetMp(int mp);
        void SetLevel(int level);
    }
}