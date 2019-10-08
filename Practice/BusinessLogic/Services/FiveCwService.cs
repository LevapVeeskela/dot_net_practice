using System;
using System.Linq;

namespace BusinessLogic.Services
{
    public class FiveCwService
    {
        public void WorkWithArray()
        {
            var minValue = 0;
            var maxValue = 50;
            var randNum = new Random();
            var tempArray = Enumerable.Repeat(0, 5)
                .Select(i => randNum.Next(minValue, maxValue))
                .ToArray(); 
            WriteInConsole(tempArray);
            Console.WriteLine(new string('-', 30));
            tempArray[2] = tempArray[2] * 10;
            WriteInConsole(tempArray);
            Console.WriteLine($"Max elem: {tempArray.Max()}");
        }

        private void WriteInConsole(int[] intArray)
        {
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}