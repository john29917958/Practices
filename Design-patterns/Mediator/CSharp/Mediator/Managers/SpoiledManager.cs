using System;
using Mediator.Employees;

namespace Mediator.Managers
{
    public class SpoiledManager : Manager
    {
        public override void TransferJob(Job job, Employee worker)
        {
            if (job.Phase == Phases.Initial)
            {
                job.Phase = Phases.UIUX;

                foreach (UIUXDesigner designer in UIUXDesigners)
                {
                    designer.TakeJob(job, true);
                }
            }
            else if (job.Phase == Phases.UIUX)
            {
                job.Phase = Phases.Code;

                foreach (Programmer programmer in Programmers)
                {
                    programmer.TakeJob(job, true);
                }
            }
            else
            {
                // Job's done, delivers to customer.
                int customerServiceId = new Random().Next(0, CustomerServices.Count);
                CustomerServices[customerServiceId].Deliver(job);
            }
        }
    }
}
