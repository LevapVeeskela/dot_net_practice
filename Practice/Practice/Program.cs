﻿using BusinessLogic.Services;
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
            var fcs = new FourCwService();
            fcs.GetCurrentTime();
            fcs.GetCountLetterAInWord();
            Console.ReadKey();
        }
    }
}
