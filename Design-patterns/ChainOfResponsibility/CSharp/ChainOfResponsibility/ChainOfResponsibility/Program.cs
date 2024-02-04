using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("Handles " + Requests.SickLeave);
            Console.WriteLine("===================");
            RequestHandler.Handle(Requests.SickLeave);
            Console.WriteLine();

            Console.WriteLine("===================");
            Console.WriteLine("Handles " + Requests.Overtime);
            Console.WriteLine("===================");
            RequestHandler.Handle(Requests.Overtime);
            Console.WriteLine();

            Console.WriteLine("===================");
            Console.WriteLine("Handles " + Requests.Resign);
            Console.WriteLine("===================");
            RequestHandler.Handle(Requests.Resign);
            Console.WriteLine();

            Console.Read();
        }
    }
}
