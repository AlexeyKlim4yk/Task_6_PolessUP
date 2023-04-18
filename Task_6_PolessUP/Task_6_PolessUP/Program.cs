using System;
using System.Text.RegularExpressions;

namespace Task_6_PolessUP
{
    

    class Program
    {
        static string ConvertToWord(double Numeric)
        {
            string WordFormat = "";
            string NumericToString = Numeric.ToString();
            foreach (char x in NumericToString)
            {
                switch (x)
                {
                    case '-': WordFormat += "minus ";break;
                    case '1': WordFormat += "one ";break;
                    case '2': WordFormat += "two ";break;
                    case '3': WordFormat += "three ";break;
                    case '4': WordFormat += "four ";break;
                    case '5': WordFormat += "five ";break;
                    case '6': WordFormat += "six ";break;
                    case '7': WordFormat += "seven ";break;
                    case '8': WordFormat += "eight ";break;
                    case '9': WordFormat += "nine ";break;
                    case ',': WordFormat += "point ";break;
                    case '.': WordFormat += "point ";break;
                }
            }
            return WordFormat;
        }
        static void Main(string[] args)
        {
            string str =ConvertToWord(-2.345);
            Console.WriteLine(str);
        }
    }
}
