using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Clock
    {
        private int second;
        private int minute;
        private int hour;

        public int Second
        {
            get { return second; }
            set
            {
                if (value >= -1 && value <= 60)
                {
                    second = value;
                }
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value >= -1 && value <= 60)
                {
                    minute = value;
                }
            }
        }

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value >= -1 && value <= 24)
                {
                    hour = value;
                }
            }
        }

        public void AddHour()
        {
            Hour++;
            if (Hour == 24)
            {
                Hour = 0;
            }
        }

        public void AddMinute()
        {
            Minute++;
            if (Minute == 60)
            {
                Minute = 0;
                AddHour();
            }
        }

        public void AddSecond()
        {
            Second++;
            if (Second == 60)
            {
                Second = 0;
                AddMinute();
            }
        }

        public void SubtractHour()
        {
            Hour--;
            if (Hour == -1)
            {
                Hour = 23;
            }
        }

        public void SubtractMinute()
        {
            Minute--;
            if (Minute == -1)
            {
                Minute = 59;
                SubtractHour();
            }
        }

        public void SubtractSecond()
        {
            Second--;
            if (Second == -1)
            {
                Second = 59;
                SubtractMinute();
            }
        }

        public void GetCurrentTime()
        {
            Console.WriteLine($"{Hour}:{Minute}:{Second}");
        }
    }
}
