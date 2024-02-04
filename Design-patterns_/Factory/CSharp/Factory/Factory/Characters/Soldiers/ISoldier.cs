namespace Factory.Characters.Soldiers
{
    public enum Soldiers { Knight, Cavalry, DragonKnight }

    public interface ISoldier
    {
        void SetHp(int hp);
        void SetMp(int mp);
    }
}