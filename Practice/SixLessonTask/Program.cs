using System;
using BusinessLogic.Services;

namespace SixLessonTask
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var scs = new SixCwService();
            scs.FirstTask();
            scs.SecondTask();
            scs.ThirdTask();
            scs.FourthTask();
            Console.ReadKey();
        }
    }
}
