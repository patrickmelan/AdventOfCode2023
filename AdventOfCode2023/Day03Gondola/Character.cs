using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03Gondola
{
    internal class Character
    {
        public Character(char thing)
        {
            char charObj = thing;
            string charAsAString;
            bool symbol = !Char.IsLetter(charObj) && !Char.IsAsciiDigit(charObj);
            if (!symbol)
            {
                charAsAString = charObj.ToString();
            }
        }
    }
}
