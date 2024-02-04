using System;
using System.Collections.Generic;
using Observer.Subjects;

namespace Observer
{
    public static class EventCenter
    {
        private static readonly List<object> Subjects = new List<object>();

        public static T FindSubject<T>() where T : class
        {
            foreach (object subject in Subjects)
            {
                T resultSubject = subject as T;

                if (resultSubject != null)
                {
                    return resultSubject;
                }
            }

            Type searchingType = typeof(T);

            if (searchingType == typeof(HitEnemySubject))
            {
                HitEnemySubject subject = new HitEnemySubject();
                Subjects.Add(subject);
                return subject as T;
            }
            else if (searchingType == typeof(KillEnemySubject))
            {
                KillEnemySubject subject = new KillEnemySubject();
                Subjects.Add(subject);
                return subject as T;
            }
            else
            {
                throw new TypeAccessException("Unsupported subject type");
            }
        }
    }
}