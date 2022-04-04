using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp
{
    internal class Alarm
    {
        public delegate void AlarmHandler(string mes);
        public event AlarmHandler DinDinEvent;

        public DateTime ResponceTime { get; }

        public Alarm(DateTime responceTime)
        {
            ResponceTime = responceTime;
        }

        public void Ring()
        {
            DinDinEvent?.Invoke($"Пора вставать!");
        }

        public override string ToString()
        {
            return $"{ResponceTime}\n";
        }
    }
}
