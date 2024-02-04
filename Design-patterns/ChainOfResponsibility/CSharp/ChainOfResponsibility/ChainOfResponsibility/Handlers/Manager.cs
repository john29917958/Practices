using System;

namespace ChainOfResponsibility.Handlers
{
    public class Manager : Handler
    {
        public override bool PassToNextOnSuccess => Request == Requests.Resign;

        public override bool IsApplicable => true;

        public Manager(Requests request) : base(request)
        {
            Name = "Manager";
        }

        public override bool Handle()
        {
            Console.WriteLine(Name + " handles the request");
            return true;
        }
    }
}