using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp
{
    internal static class Service
    {
        public static void CheckAlarm(object? o)
        {
            Alarm alarm = (Alarm)o;
            alarm.DinDinEvent += DisplayMessage;
            

            if (DateTime.Now.Hour.Equals(alarm.ResponceTime.Hour) &&
                DateTime.Now.Minute.Equals(alarm.ResponceTime.Minute) &&
                DateTime.Now.Second.Equals(alarm.ResponceTime.Second))
            {
                alarm.Ring();
            }
        }

        public static void DisplayMessage(string message) => Console.WriteLine(message);
    }
}
