using BusinessLogic.Services;
using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var cw = new FourCwService();
            cw.GetCurrentTime();
            Console.ReadKey();
        }
    }
}
