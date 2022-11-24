using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RemakeProject.ViewModels
{
    public class HelperAnalyzer
    {

        public static int CountVowels(string text)
        {
            int number = 0;
            Regex pattern = new("[уеыаоэяиюeuoiay]");
            if (text != null)
            {
                text = text.ToLower();
                number = pattern.Matches(text).Count;
            }
            return number;
        }
        public static int CountConsonants(string text)
        {
            int number = 0;
            Regex pattern = new("[йцкнгшщзхфвпрлджчсмтбqwrtpsdfghjklzxcvbnm]");
            if (text != null)
            {
                text = text.ToLower();
                number = pattern.Matches(text).Count;
            }
            return number;
        }
        public static int CountNumbers(string text)
        {
            int number = 0;
            Regex pattern = new("[1234567890]");
            if (text != null)
            {
                number = pattern.Matches(text).Count;
            }
            return number;
        }
        public static int CountSpecialSymbols(string text)
        {
            int number = 0;
            Regex pattern = new("[-=+!@#$%^&*()№;%:?_'\".,/]");
            if (text != null)
            {
                number = pattern.Matches(text).Count;
            }
            return number;
        }
    }
}
