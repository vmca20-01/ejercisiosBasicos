using System;
using System.Timers;

namespace ejercisiosBasicos
{
    public static class DigitalClock
    {
        public static Timer aTimer;
        public static int second = 0;
        public static int minute = 0;
        public static int hour = 0;

        public static void SetTimer()
        {
            aTimer = new Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.Write("\r {0}:{1}:{2}", (minute == 60 ? hour++ : 0), (second == 60 ? minute++ : 0), second++);
        }

        public static int minutes()
        {
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            return minute;
        }
    }
}
