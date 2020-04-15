using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace BadSuperbowlNamer
{
    public class Translator
    {
        public string Translate( int number)
        {
            var romanNumeral = "";
            while (number > 0)
            {
                if (number == 1)
                    romanNumeral += "I";
                else if (number == 3)
                    romanNumeral += "III";
                else if (number == 5)
                    romanNumeral += "v";
                else if (number == 9)
                    romanNumeral += "IV";
            }

            return "I don't know.";
        }
    }
}
