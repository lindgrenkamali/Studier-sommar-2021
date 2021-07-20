﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PacktLibrary.Shared
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            //använd simpla uttryck för att kolla om inmatningen är en email
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }

    }
}
