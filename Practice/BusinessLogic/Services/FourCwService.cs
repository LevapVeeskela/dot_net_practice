using Common.Constants;
using System;
using Common.Helpers;

namespace BusinessLogic.Services
{
    public class FourCwService
    {
        public void GetCurrentTime()
        {
            var today = DateTime.Now.TimeOfDay;
            var stringTime = $"Right now time: {today.Hours}:{today.Minutes}:{today.Seconds}";

            Console.WriteLine(FourCwHelper.GetCurrentTimeInString(today));
            Console.WriteLine(stringTime);
        }
    }
}
