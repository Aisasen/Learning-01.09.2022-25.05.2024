using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2
{
    internal class MyString
    {
        public string text;
        public string Reverse(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public string UcFirst(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1);
        }

        public string UcWords(string text)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string titleCase = textInfo.ToTitleCase(text);
            return titleCase;
        }
    }
}

