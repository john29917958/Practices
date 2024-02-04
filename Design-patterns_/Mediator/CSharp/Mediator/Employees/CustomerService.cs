using Mediator.Managers;

namespace Mediator.Employees
{
    public class CustomerService : Employee
    {
        public CustomerService(string name, Manager manager) : base(name, manager)
        {
            
        }

        public void Negotiate(Job job)
        {
            // Negotiates with customer.
        }

        public void Deliver(Job job)
        {
            // Delivers job to customer.
        }

        public override bool TakeJob(Job job, bool isForceMode = false)
        {
            Manager.TransferJob(job, this);
            return true;
        }
    }
}
