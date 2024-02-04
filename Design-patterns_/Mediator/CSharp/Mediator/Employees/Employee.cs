using System;
using System.Collections.Generic;
using Mediator.Managers;

namespace Mediator.Employees
{
    public enum Mood { Thrilled, Good, Normal, Bad, Angry }

    public abstract class Employee
    {
        public string Name { get; protected set; }

        public int Health { get; protected set; }

        public Mood Mood { get; protected set; }

        public readonly List<Job> Jobs;

        protected Manager Manager;

        protected Employee(string name, Manager manager)
        {
            Name = name;
            Jobs = new List<Job>();
            Health = 100;
            Mood = Mood.Good;
            Manager = manager;
        }

        public virtual bool TakeJob(Job job, bool isForceMode = false)
        {
            if (Mood == Mood.Angry && !isForceMode) return false;

            Jobs.Add(job);

            if (Jobs.Count <= 3)
            {
                Mood = Mood.Thrilled;
            }
            else if (Jobs.Count <= 5)
            {
                Mood = Mood.Good;
            }
            else if (Jobs.Count <= 7)
            {
                Mood = Mood.Normal;
            }
            else if (Jobs.Count <= 9)
            {
                Mood = Mood.Bad;
            }
            else
            {
                Mood = Mood.Angry;
            }

            return true;
        }

        public virtual void DoJob()
        {
            if (Jobs.Count == 0) return;

            int index = new Random().Next(Jobs.Count);
            Job completedJob = Jobs[index];
            Jobs.RemoveAt(index);
            Manager.TransferJob(completedJob, this);
        }
    }
}
