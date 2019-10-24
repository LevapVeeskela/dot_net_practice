using System;
using Common.Models;

namespace BusinessLogic.Services
{
    public class ThirteenCwFirstTaskService
    {
        private SongModel CurrentSongData { get;  }

        public ThirteenCwFirstTaskService(SongModel songData)
        {
            CurrentSongData = songData;
        }

        public Object GetSongData()
        {
            return new { Title = CurrentSongData.NameSong, Minutes = CurrentSongData.DurationSong, AlbumYear = CurrentSongData.YearSong };
        }

        public Tuple<string, int?, string, int?> GetSongDataTuple()
        {
            return Tuple.Create(CurrentSongData.NameSong, CurrentSongData.DurationSong, CurrentSongData.AuthorSong, CurrentSongData.YearSong);

        }
    }
}
