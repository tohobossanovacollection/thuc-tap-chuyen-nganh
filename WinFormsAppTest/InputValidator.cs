using System.Text.RegularExpressions;
using System.Linq;

namespace WinFormsAppTest
{
    public static class InputValidator
    {
        private static readonly Regex NameRegex = new(@"^[\p{L}\s]+$", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        private static readonly Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

        public static bool IsValidName(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            return NameRegex.IsMatch(value.Trim());
        }

        public static bool IsValidPhone(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            string trimmed = value.Trim();
            return trimmed.Length >= 10 && trimmed.All(char.IsDigit);
        }

        public static bool IsValidEmail(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            return EmailRegex.IsMatch(value.Trim());
        }
    }
}
