using System;
using System.Collections.Generic;

namespace PracticeFive
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<object>();
            var collection2 = new List<object>
            {
                43,
                DayOfWeek.Thursday,
                "hello",
                null,
                false
            };
            collection.AddRange(collection2);
            foreach (var item in collection)
            {
                switch (item)
                {
                    case string txt when txt.Equals("hello"):
                        Console.WriteLine(txt);
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine(DayOfWeek.Thursday);
                        break;
                }
            }
        }
    }
}
