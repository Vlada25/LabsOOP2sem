using AlarmApp;

int menuItem = -1;

try
{
    while (menuItem != 0)
    {
        Console.WriteLine("\n--- МЕНЮ ---\n" +
            "1. Добавить будильник\n" +
            "2. Удалить будильник\n" +
            "3. Задать текущее время\n" +
            "4. Просмотреть список будильников\n" +
            "0. Выход");

        menuItem = Convert.ToInt32(Console.ReadLine());

        switch (menuItem)
        {
            case 0:
                Console.WriteLine("Программа завершена");
                break;
            case 1:
                Console.WriteLine("Введите время срабатывания будильника:");
                Service.CreateAlarm(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("Введите номер будильника:");
                Service.DeleteAlarm(Convert.ToInt32(Console.ReadLine()));
                break;
            case 3:
                Console.WriteLine("Задайте текущее время:");
                TimeOnly curTime = TimeOnly.Parse(Console.ReadLine());

                foreach (Alarm alarm in Service.Alarms)
                {
                    alarm.DinDinEvent += Service.DisplayMessage;
                    alarm.Ring(curTime);
                }
                break;
            case 4:
                Console.WriteLine(Service.ViewAllAlarms());
                break;
            default:
                Console.WriteLine("Такого пункта меню не существует");
                break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
