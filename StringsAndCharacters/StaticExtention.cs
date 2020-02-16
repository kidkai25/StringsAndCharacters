using System;
using System.Collections.Generic;
using System.Text;
using StringsAndCharacters;

namespace xx
{

        public static class CharStrExtMethods
        {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
        public static CharKind GetCharKind(this char theChar)
            {
                if (Char.IsLetter(theChar))
                {
                    return CharKind.Letter;
                }
                else if (Char.IsNumber(theChar))
                {
                    return CharKind.Number;
                }
                else if (Char.IsPunctuation(theChar))
                {
                    return CharKind.Punctuation;
                }
                else
                {
                    return CharKind.Unknown;
                }
            }

            //An overload
            public static CharKind GetCharKindInString(this string theString, int charPosition)
            {
                if (Char.IsLetter(theString, charPosition))
                {
                    return CharKind.Letter;
                }
                else if (Char.IsNumber(theString, charPosition))
                {
                    return CharKind.Number;
                }
                else if (Char.IsPunctuation(theString, charPosition))
                {
                    return CharKind.Punctuation;
                }
                else
                {
                    return CharKind.Unknown;
                }

            }
        }
    
}
