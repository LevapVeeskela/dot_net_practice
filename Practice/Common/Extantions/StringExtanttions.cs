namespace Common.Extantions
{
    public static class StringExtanttions
    {
        public static string SubstringFirstLetter(this string row)
        {
            var substring = row.Substring(0, 5);
            return string.Concat(substring, "...");
        }
    }
}
