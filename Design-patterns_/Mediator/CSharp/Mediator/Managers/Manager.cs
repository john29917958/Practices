using System.Collections.Generic;
using Mediator.Employees;

namespace Mediator.Managers
{
    public abstract class Manager
    {
        public readonly List<CustomerService> CustomerServices;
        public readonly List<UIUXDesigner> UIUXDesigners;
        public readonly List<Programmer> Programmers;

        protected Manager()
        {
            CustomerServices = new List<CustomerService>();
            UIUXDesigners = new List<UIUXDesigner>();
            Programmers = new List<Programmer>();
        }

        public abstract void TransferJob(Job job, Employee worker);
    }
}
