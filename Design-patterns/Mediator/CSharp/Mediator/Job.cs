namespace Mediator
{
    public enum Phases { Initial, UIUX, Code }

    public struct Job
    {
        public int Id;
        public string Name;
        public Phases Phase;
    }
}
