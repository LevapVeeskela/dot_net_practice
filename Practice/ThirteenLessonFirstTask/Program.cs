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
            var song = new SongModel { NameSong = "NAME", DurationSong = 12, YearSong = 2018, AuthorSong = "I" };
            var tcfts = new ThirteenCwFirstTaskService(song);
            var songDataTuple = tcfts.GetSongDataTuple();
            var songData = tcfts.GetSongData();
            Console.WriteLine($"{songDataTuple.Item1}, {songDataTuple.Item2}, {songDataTuple.Item3}, {songDataTuple.Item4}");
            var type = songData.GetType();
            Console.WriteLine($"{(string)type.GetProperty("Title").GetValue(songData)}, {(int)type.GetProperty("Minutes").GetValue(songData)}, {(int)type.GetProperty("AlbumYear").GetValue(songData)}");
        }

        static void RunSecondTask()
        {
            const string TextInfo = "Please, enter value more 5 letters";
            Console.WriteLine(TextInfo);
            Console.Write(Console.ReadLine().SubstringFirstLetter());
            Console.ReadKey();
        }
    }
}
