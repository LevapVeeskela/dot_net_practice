using System;
using Common.Constants;

namespace Common.Helpers
{
    public static class FourCwHelper
    {
        public static string GetCurrentTimeInString(TimeSpan day) => day switch
        {
            _ when day.Hours >= 9 && day.Hours < 12 => FourCw.MorningText,
            _ when day.Hours >= 12 && day.Hours < 15 => FourCw.DayText,
            _ when day.Hours >= 15 && day.Hours < 22 => FourCw.EveningText,
            _ when day.Hours >= 22 && day.Hours < 9 => FourCw.NightText
        };
    }
}