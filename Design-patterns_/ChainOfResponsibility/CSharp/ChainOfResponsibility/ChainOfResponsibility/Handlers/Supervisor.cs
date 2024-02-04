using System;

namespace ChainOfResponsibility.Handlers
{
    public class Supervisor : Handler
    {
        public override bool PassToNextOnSuccess => Request != Requests.Resign;

        public override bool IsApplicable => true;

        public Supervisor(Requests request) : base(request)
        {
            Name = "Supervisor";
        }

        public override bool Handle()
        {
            Console.WriteLine(Name + " handles the request");
            return true;
        }
    }
}