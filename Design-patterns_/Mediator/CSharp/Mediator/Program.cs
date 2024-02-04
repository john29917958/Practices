using Mediator.Employees;
using Mediator.Managers;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager experiencedManager = new ExperiencedManager();
            experiencedManager.CustomerServices.Add(new CustomerService("Emily", experiencedManager));
            experiencedManager.CustomerServices.Add(new CustomerService("Laura", experiencedManager));
            experiencedManager.CustomerServices.Add(new CustomerService("Alice", experiencedManager));

            experiencedManager.UIUXDesigners.Add(new UIUXDesigner("John", experiencedManager));
            experiencedManager.UIUXDesigners.Add(new UIUXDesigner("Sarah", experiencedManager));
            experiencedManager.UIUXDesigners.Add(new UIUXDesigner("Rebecca", experiencedManager));

            experiencedManager.Programmers.Add(new Programmer("Jack", experiencedManager));
            experiencedManager.Programmers.Add(new LazyProgrammer("I'm lazy", experiencedManager));
            experiencedManager.Programmers.Add(new Programmer("George", experiencedManager));

            experiencedManager.CustomerServices[0].TakeJob(new Job
            {
                Id = 0,
                Name = "Shopping web",
                Phase = Phases.Initial
            });

            foreach (UIUXDesigner designer in experiencedManager.UIUXDesigners)
            {
                designer.DoJob();
            }

            foreach (Programmer programmer in experiencedManager.Programmers)
            {
                programmer.DoJob();
            }
        }
    }
}
