using System;
using BusinessLogic.Services;
using Common.Extantions;
using Common.Models;

namespace ThirteenLessonFirstTask
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
            var song = new SongModel{ NameSong = "NAME", DurationSong = 12, YearSong = 2018, AuthorSong = "I" };
            var tcfts = new ThirteenCwFirstTaskService(song);
            var getSong = tcfts.GetSongDataTuple();
            Console.WriteLine($"{getSong.Item1}, {getSong.Item2}, {getSong.Item3}, {getSong.Item4}");
        }

        static void RunSecondTask()
        {
            Console.Write(Console.ReadLine().SubstringFirstLetter());
            Console.ReadKey();
        }
    }
}
