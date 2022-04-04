using AlarmApp;

try
{
    int x = 0;
    while (x == 0)
    {
        Alarm alarm = new Alarm(new DateTime(2022, 4, 4, 15, 21, 0));

        Console.WriteLine("Будильник установлен на:");
        Console.WriteLine(alarm.ToString());

        Timer timer = new Timer(Service.CheckAlarm, (object)alarm, 0, 1000);

        x = Convert.ToInt32(Console.ReadLine());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
