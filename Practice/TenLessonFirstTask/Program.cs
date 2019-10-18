using System;
using BusinessLogic.Services;

namespace TenLessonFirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFirstTask();
            RunSecondTask();
        }

        static void RunFirstTask()
        {
            var tcfts = new TenCwFirstTaskService();
            tcfts.WriteInConsole(tcfts.GetThreeForm());
        }
        static void RunSecondTask()
        {
            var firstItem = new UniqueItem();
            var secondItem = new UniqueItem(10);
            var thirdItem = new UniqueItem();
            Console.ReadKey();
        }
    }
}
