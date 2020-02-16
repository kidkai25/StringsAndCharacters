using System;
using xx;

namespace StringsAndCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //CharStrExtMethods.GetCharKindInString("xx")l
            int i = 10;
           
            string data = "abcdefg";
            if (data.GetCharKindInString(4) == CharKind.Digit)
            {
                Console.WriteLine("Contains");
            }
            else
            {
                Console.WriteLine("Doesn't Contain ");
            }
                 
        }
    }
}
