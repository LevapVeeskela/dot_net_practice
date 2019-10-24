using System;
using System.Collections.Generic;
using System.Linq;
using Common.Constants;

namespace BusinessLogic.Services
{
    public class SixCwService
    {
        public void FirstTask()
        {
            Console.WriteLine(Constants.SixCw.TextFirstTaskInfo);
            var listInt = new List<int>();
            int[] emptyArray = listInt.ToArray();
            WriteInConsole(emptyArray);
            Console.WriteLine(Constants.SixCw.TextPossibleInfo);
            Console.WriteLine(Constants.SixCw.TextManyLinesInfo);
        }

        public void SecondTask()
        {
            Console.WriteLine(Constants.SixCw.TextSecondTaskInfo);
            object[] arrayThreeItems = { 32, 'A', "Hello" };
            WriteInConsole(arrayThreeItems);
            Console.WriteLine(Constants.SixCw.TextManyLinesInfo);
            arrayThreeItems[0] = (int)arrayThreeItems[0] + 10;
            arrayThreeItems[1] = $"{arrayThreeItems[1]}, guys!";
            WriteInConsole(arrayThreeItems);
            Console.WriteLine(Constants.SixCw.TextManyLinesInfo);
        }

        public void ThirdTask()
        {
            Console.WriteLine(Constants.SixCw.TextThridTaskInfo);
            var randNum = new Random();
            var tempArray = Enumerable.Repeat(Constants.SixCw.InitRangeValueDefault, Constants.SixCw.FinishRangeValueRepeatDefault)
                .Select(i => randNum.Next(Constants.SixCw.InitRangeValueDefault, Constants.SixCw.FinishRangeValueDefault))
                .ToArray();
            WriteInConsole(tempArray);
            Console.WriteLine($"Max elem: {tempArray.Max()}");
            Console.WriteLine(Constants.SixCw.TextManyLinesInfo);
        }

        public void FourthTask()
        {
            Console.WriteLine(Constants.SixCw.TextFourthTaskInfo);
            short itemOne = 2;
            short itemTwo = 3;
            object[] tempArray = {
                itemOne, itemTwo
            };
            Console.WriteLine(Constants.SixCw.TextUnboxingInfo);
            WriteInConsoleUnboxingShortType(tempArray);
        }

        /// <summary>
        /// Method writes in console and do to unboxing
        /// </summary>
        /// <typeparam name="T">Any type</typeparam>
        /// <param name="array">Any array</param>
        private void WriteInConsole<T>(T[] array)
        {
            foreach (var item in array)
            {
                var result = Convert.ChangeType(item, item.GetType());
                Console.WriteLine(result);
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