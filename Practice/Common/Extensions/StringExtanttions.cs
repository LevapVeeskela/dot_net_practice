namespace Common.Extensions
{
    public static class StringExtensions
    {
        public static string SubstringFirstLetter(this string row)
        {
            var substring = row.Substring(0, 5);
            return string.Concat(substring, "...");
        }
    }
}
