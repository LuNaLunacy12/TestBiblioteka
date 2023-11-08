using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramBibliary
{
    public class ProgramBibliary
    {

        public static TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };

        public static int[] duration = new int[] { 60, 30, 10, 10, 40 };
        public static TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
        public static TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

        public static int consultationTime = 30;
        static void Main(string[] args)
        {


            for (TimeSpan i = beginWorkingTime; i < endWorkingTime;)
            {
                TimeSpan Finish = i + TimeSpan.FromMinutes(consultationTime);
                TimeSpan st;
                if (IsAvalable(i, Finish, out st))
                {
                    Console.WriteLine(i.Hours + ":" + i.Minutes + "-" + Finish.Hours + ":" + Finish.Minutes);
                    i += TimeSpan.FromMinutes(consultationTime);
                }
                else
                {
                    i = st;
                }
            }
            Console.ReadKey();
        }

        //public  List<string> AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        //{


        //}
        public static bool IsAvalable(TimeSpan start, TimeSpan finish, out TimeSpan ts)
        {
            ts = finish;


            for (int i = 0; i < duration.Length; i++)
            {
                TimeSpan begin = startTimes[i];
                TimeSpan end = startTimes[i] + TimeSpan.FromMinutes(duration[i]);
                if (start >= end)
                {
                    continue;
                }
                if (start >= begin)
                {
                    ts = end;
                    return false;
                }
                if (finish <= begin)
                {
                    continue;
                }
                ts = end;
                return false;
            }

            return true;
        }
    }
}
