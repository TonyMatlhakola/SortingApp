using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SortingApp
{
   public class StringAnalyser
    {

        public string DiscardPunctuation(string text)
        {
            text = Regex.Replace(text, @"[^A-Za-z]", string.Empty).ToLower();
            return text.Trim();
        }
        

    }
}
