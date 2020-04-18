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
                if (number >= 1000)
                {
                    romanNumeral += "M";
                    number -= 1000;
                }
                else if (number >= 900)
                {
                    romanNumeral += "CM";
                    number -= 900;
                }
                else if (number >= 500)
                {
                    romanNumeral += "D";
                    number -= 500;
                }
                else if (number >= 100)
                {
                    romanNumeral += "C";
                    number -= 100;
                }
                else if (number >= 90)
                {
                    romanNumeral += "XC";
                    number -= 90;
                }
                else if (number >= 50)
                {
                    romanNumeral += "L";
                    number -= 50;
                }
                else if (number >= 40)
                {
                    romanNumeral += "XL";
                    number -= 40;
                }
                else if (number >= 10)
                {
                    romanNumeral += "X";
                    number -= 10;
                }
                else if (number == 9)
                {
                    romanNumeral += "IX";
                    number -= 9;
                }
                else if (number >= 5)
                {
                    romanNumeral += "V";
                    number -= 5;
                }
                else if (number == 4)
                {
                    romanNumeral += "IV";
                    number -= 4;
                }
                else if (number >= 1)
                {
                    romanNumeral += "I";
                    number -= 1;
                }
            }

            return "I don't know.";
        }
    }
}
