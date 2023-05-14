using System.Text.RegularExpressions;

namespace MiniProject.Business.Helpers;

public static class Extensions
{
    public static bool IsOnlyLetter(this string value)
    {
        return Regex.IsMatch(value, @"^[a-zA-Z]+$");
    }
}

