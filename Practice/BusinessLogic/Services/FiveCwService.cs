using System;
using System.Linq;

namespace BusinessLogic.Services
{
    public class FiveCwService
    {
        public void WorkWithArray()
        {
            var tempArrat = new int[] {
                new Random().Next(0, 50),
                new Random().Next(0, 50),
                new Random().Next(0, 50),
                new Random().Next(0, 50),
                new Random().Next(0, 50),
                new Random().Next(0, 50)
            };
            WriteInConsole(tempArrat);
            Console.WriteLine(new string('-', 30));
            tempArrat[2] = tempArrat[2] * 10;
            WriteInConsole(tempArrat);
            Console.WriteLine($"Max elem: {tempArrat.Max()}");
        }

        public void WriteInConsole(int[] intArray)
        {
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}