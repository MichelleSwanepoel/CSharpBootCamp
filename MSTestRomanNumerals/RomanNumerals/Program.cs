using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Program
    {
        Dictionary<char, int> numeralMap;
        public Program()
        {
            numeralMap = new Dictionary<char, int>();
            numeralMap.Add('I', 1);
            numeralMap.Add('V', 5);
            numeralMap.Add('X', 10);
            numeralMap.Add('L', 50);
            numeralMap.Add('C', 100);
            numeralMap.Add('D', 500);
            numeralMap.Add('M', 1000);
        }       

        public int ConvertRomanNumeralToArabic(string roman)
        {
            if (roman.Length == 1)
                return numeralMap[roman[0]];

            char prevchar = roman[roman.Length - 1];
            int finalval = numeralMap[prevchar];

            for (int i = roman.Length - 2; i >= 0; i--)
            {
                char currentchar = roman[i];

                if (numeralMap[currentchar] >= numeralMap[prevchar])
                    finalval += numeralMap[currentchar];
                else
                    finalval -= numeralMap[currentchar];

                prevchar = currentchar;
            }
            return finalval;
        }
    }
}
