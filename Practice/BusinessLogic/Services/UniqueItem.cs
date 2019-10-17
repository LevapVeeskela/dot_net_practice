using System;
using Common.Helpers;

namespace BusinessLogic.Services
{
    public class UniqueItem
    {
        public UniqueItem(int item = 0)
        {
            var item1 = item + TenLessonSecondTask.Item + 1;
            TenLessonSecondTask.Item = item1;
            Console.WriteLine(item1);
        }
    }
}