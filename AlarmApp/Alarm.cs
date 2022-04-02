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
        public TimeOnly ResponceTime { get; }
        public int Number { get; set; }

        public Alarm(int number, TimeOnly responceTime)
        {
            ResponceTime = responceTime;
            Number = number;
        }

        public void Ring(TimeOnly currentTime)
        {
            if (currentTime.Equals(ResponceTime))
            {
                DinDinEvent?.Invoke($"Пора вставать! (будильник #{Number} сработал)");
            }
            else
            {
                DinDinEvent?.Invoke($"Время будильника #{Number} ещё не пришло...");
            }
        }

        public override string ToString()
        {
            return $"#{Number} - {ResponceTime}\n";
        }
    }
}
