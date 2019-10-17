using System;
using Common.Helpers;

namespace BusinessLogic.Services
{
    public class UniqueItem
    {
        private readonly int _item;
        public UniqueItem(int item = 0)
        {
            _item = item + TenLessonSecondTask.Item + 1;
            TenLessonSecondTask.Item = _item;
            Console.WriteLine(_item);
        }

    }
}