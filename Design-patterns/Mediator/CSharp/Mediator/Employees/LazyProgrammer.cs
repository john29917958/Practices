using System;
using Mediator.Managers;

namespace Mediator.Employees
{
    public class LazyProgrammer : Programmer
    {
        public LazyProgrammer(string name, Manager manager) : base(name, manager)
        {

        }

        public override void DoJob()
        {
            if (Jobs.Count == 0) return;
            if (Mood == Mood.Angry || Mood == Mood.Bad || Mood == Mood.Normal || Mood == Mood.Good) return;

            int index = new Random().Next(Jobs.Count);
            Job completedJob = Jobs[index];
            Jobs.RemoveAt(index);
            Manager.TransferJob(completedJob, this);
        }
    }
}
