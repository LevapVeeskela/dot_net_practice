using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string MorningText = "Good morning, guys!";
            const string DayText = "Good day, guys!";
            const string EveningText = "Good evening, guys!";
            const string NightText = "Good night, guys!";

            var today = DateTime.Now.TimeOfDay;
            
            if (today.Hours > 9 && today.Hours < 12)
            {
                Console.WriteLine(MorningText);
            }
            else if (today.Hours > 12 && today.Hours < 15)
            {
                Console.WriteLine(DayText);
            }
            else if (today.Hours > 15 && today.Hours < 22)
            {
                Console.WriteLine(EveningText);
            }
            else if (today.Hours > 22 && today.Hours < 9)
            {
                Console.WriteLine(NightText);
            }

            var stringTime = $"Right now time: {today.Hours}:{today.Minutes}:{today.Seconds}";
            Console.WriteLine(stringTime);
            Console.ReadKey();

        }
    }
}
