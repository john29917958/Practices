using System;

namespace ChainOfResponsibility.Handlers
{
    public class Leader : Handler
    {
        public override bool PassToNextOnSuccess => true;

        public override bool IsApplicable => Request == Requests.SickLeave;

        public Leader(Requests request) : base(request)
        {
            Name = "Leader";
        }

        public override bool Handle()
        {
            Console.WriteLine(Name + " handles the request");
            return true;
        }
    }
}