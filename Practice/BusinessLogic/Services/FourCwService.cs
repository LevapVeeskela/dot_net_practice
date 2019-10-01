using Common.Constants;
using System;
using System.Linq;
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

        public void GetCountLetterAInWord()
        {
            Console.WriteLine("Enter word with letter A");
            while (true)
            {
                var word = Console.ReadLine();
                var latters = word?.ToCharArray();
                Console.WriteLine($"Count letter A: {latters.Count(latter => latter == 'a' || latter == 'A')}");
                if (word == "exit" || word == "Exit") break;
            }
        }
    }
}
