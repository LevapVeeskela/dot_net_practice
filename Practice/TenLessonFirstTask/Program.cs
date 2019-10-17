using System;
using BusinessLogic.Services;

namespace TenLessonFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var tcfts = new TenCwFirstTaskService();
            tcfts.WriteInConsole(tcfts.GetThreeForm());
            Console.ReadKey();
        }
    }
}
