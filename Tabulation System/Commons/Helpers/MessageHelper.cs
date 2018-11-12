
namespace Tabulation_System.Commons.Helpers
{
    public static class MessageHelper
    {
        public static string DuplicateRecord(string text)
        {
            return string.Format("{0} is already used.", text);
        }

        public static string NoInput()
        {
            return "input required.";
        }

        public static string NoSelectedRecord()
        {
            return "No selected record found. Select record first.";
        }

        public static string InvalidTextRange(int minimum, int maximum)
        {
            return @"input must have a range between {minimum} to {maximum} characters.";
        }

        public static string InvalidValueRange(int minimum, int maximum)
        {
            return @"value must have a range between {minimum} to {maximum}.";
        }
    }
}
