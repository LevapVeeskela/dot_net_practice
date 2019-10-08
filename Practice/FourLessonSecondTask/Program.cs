using System;
using BusinessLogic.Services;

namespace FourLessonSecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var fcs = new FourCwService();
            fcs.GetCountLetterAInWord();
            Console.ReadKey();
        }
    }
}
