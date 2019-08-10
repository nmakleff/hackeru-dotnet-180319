using System;

namespace AlarmClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm();
            alarm.Start();
            Console.ReadLine();
            alarm.Stop();

        }
    }
}
