using System;
using Mediator.Employees;

namespace Mediator.Managers
{
    public class ExperiencedManager : Manager
    {
        public override void TransferJob(Job job, Employee worker)
        {
            if (job.Phase == Phases.Initial)
            {
                job.Phase = Phases.UIUX;

                foreach (UIUXDesigner designer in UIUXDesigners)
                {
                    if (designer.Mood != Mood.Angry && designer.Mood != Mood.Bad && designer.Health >= 50)
                    {
                        designer.TakeJob(job);
                        return;
                    }
                }

                // No appropriate worker found. Negotiate with customer.
                int customerServiceId = new Random().Next(0, CustomerServices.Count);
                CustomerServices[customerServiceId].Negotiate(job);
            }
            else if (job.Phase == Phases.UIUX)
            {
                job.Phase = Phases.Code;

                foreach (Programmer programmer in Programmers)
                {
                    if (programmer.Mood != Mood.Angry && programmer.Mood != Mood.Bad && programmer.Health >= 50)
                    {
                        programmer.TakeJob(job);
                        return;
                    }
                }

                // No appropriate worker found. Negotiate with customer.
                int customerServiceId = new Random().Next(0, CustomerServices.Count);
                CustomerServices[customerServiceId].Negotiate(job);
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
