using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Services
{
    public class SixCwService
    {
        public void FirstTask()
        {
            Console.WriteLine("First Task");
            const string textPossibleInfo = "Everything is possible in this life";
            var listInt = new List<int>();
            int[] emptyArray = listInt.ToArray();
            WriteInConsole(emptyArray);
            Console.WriteLine(emptyArray);
            Console.WriteLine($"{textPossibleInfo}");
            Console.WriteLine(new string('-', 50));
        }

        public void SecondTask()
        {
            Console.WriteLine("Second Task");
            object[] arrayThreeItems = { 32, 'A', "Hello" };
            WriteInConsole(arrayThreeItems);
            Console.WriteLine(new string('-', 50));
            arrayThreeItems[0] = (int)arrayThreeItems[0] + 10;
            arrayThreeItems[1] = $"{arrayThreeItems[1]}, guys!";
            WriteInConsole(arrayThreeItems);
            Console.WriteLine(new string('-', 50));
        }

        public void ThirdTask()
        {
            Console.WriteLine("Third Task");
            var minValue = 0;
            var maxValue = 50;
            var randNum = new Random();
            var tempArray = Enumerable.Repeat(0, 12)
                .Select(i => randNum.Next(minValue, maxValue))
                .ToArray();
            WriteInConsole(tempArray);
            Console.WriteLine($"Max elem: {tempArray.Max()}");
            Console.WriteLine(new string('-', 50));
        }

        public void FourthTask()
        {
            Console.WriteLine("Fourth Task");
            short itemOne = 2;
            short itemTwo = 3;
            object[] tempArray = {
                itemOne, itemTwo
            };
            Console.WriteLine("Unboxing при считывание по элементам");
            WriteInConsoleUnboxingShortType(tempArray);
        }

        private void WriteInConsole<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private void WriteInConsoleUnboxingShortType(object[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine((short)item);
            }
        }
    }
}