using System;
using System.Text.RegularExpressions;

namespace SharedLibrary
{
    public static class StringExtensions
    {
        public static bool IsValidXMLTag(this string input)
        {
            return Regex.IsMatch(input, @"^([a-z]+)([^<]+)*(?:>(.*)<\/\1>|\s+\/>)$");
        }

        public static bool IsValidPassword(this string input)
        {
            //Minsta tillåtna antal "verifierade" tecken
            return Regex.IsMatch(input, "^[a-zA-Z0-9_-]{8,}$");
        }

        public static bool IsValidHex(this string input)
        {
            //Tre eller sex hexnummer karaktärer
            return Regex.IsMatch(input, "^#?([a-fA-F0-9]{3}|[a-fA-F0-9]{6})$");
        }

    }
}
