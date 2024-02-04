using Mediator.Employees;

namespace Mediator.Managers
{
    public class DoNothingManager : Manager
    {
        public override void TransferJob(Job job, Employee worker)
        {
            // Just do nothing...
        }
    }
}
