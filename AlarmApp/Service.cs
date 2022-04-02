using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmApp
{
    internal static class Service
    {
        public static List<Alarm> Alarms { get; } = new List<Alarm>
        {
            new Alarm(1, new TimeOnly(7, 0, 0)),
            new Alarm(2, new TimeOnly(7, 30, 0)),
            new Alarm(3, new TimeOnly(8, 0, 0)),
        };

        public static void CreateAlarm(string time)
        {
            Alarms.Add(new Alarm(Alarms.Count + 1, TimeOnly.Parse(time)));
        }

        public static void DeleteAlarm(int number)
        {
            if (IsAlarmExist(number))
            {
                Alarms.RemoveAt(number - 1);
                for (int i = number - 1; i < Alarms.Count; i++)
                {
                    Alarms[i].Number--;
                }
            }
        }

        public static string ViewAllAlarms()
        {
            string res = "";

            foreach (Alarm alarm in Alarms)
            {
                res += alarm.ToString();
            }

            return res;
        }

        private static bool IsAlarmExist(int number)
        {
            foreach (Alarm alarm in Alarms)
            {
                if (alarm.Number == number) return true;
            }

            return false;
        }

        public static void DisplayMessage(string message) => Console.WriteLine(message);
    }
}
