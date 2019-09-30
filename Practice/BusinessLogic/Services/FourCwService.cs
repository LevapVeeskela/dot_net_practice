using Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Services
{
    public class FourCwService
    {
        public void GetCurrentTime()
        {
            var today = DateTime.Now.TimeOfDay;

            if (today.Hours >= 9 && today.Hours < 12)
            {
                Console.WriteLine(FourCw.MorningText);
            }
            else if (today.Hours >= 12 && today.Hours < 15)
            {
                Console.WriteLine(FourCw.DayText);
            }
            else if (today.Hours >= 15 && today.Hours < 22)
            {
                Console.WriteLine(FourCw.EveningText);
            }
            else if (today.Hours >= 22 && today.Hours < 9)
            {
                Console.WriteLine(FourCw.NightText);
            }

            var stringTime = $"Right now time: {today.Hours}:{today.Minutes}:{today.Seconds}";
            Console.WriteLine(stringTime);
        }
    }
}
