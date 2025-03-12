using System;
using System.Net;

namespace BetterDecorador
{
    /// <summary>
    /// Receives string from command line that is altered by the method Decor, 
    // so around that string the inputted character is multiplied by the int 
    // number
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Receives string and the inputted character surrounds set string
        /// that inputted character is repeated by the whole(int) number inserted
        /// </summary>
        /// <param name="s">string</param>
        /// <param name="dec">character that surrounds string </param>
        /// <param name="count"> the number that determines the amount of
        // times the character appears</param>
        /// <returns> string with characters </returns>
        private static string Decor(string s , char dec, int count)
        {
            /*
            string border = new string(dec,num);
            return $"{border}{s}{border}";
            */

            int n = 0;
            s = " " + s + " ";
            while(n != count)
            {
                s = dec + s + dec;
                ++n;
            }
            return s;

        }
        /// <summary>
        /// Parses string from Method Decor that is received from the command line
        /// </summary>
        /// <param name="args"> arguments from command line</param>
        private static void Main(string[] args)
        {
            /*
            Console.WriteLine (Decor("Good Morning!", '*', 3));
            Console.WriteLine (Decor("Good Evening !", '.',2));
            */
            if(args.Length == 0)
            {
                Console.WriteLine("Specify Args");
            }
            else
            {
               Console.WriteLine(Decor(args[0],char.Parse(args[1]), 
            int.Parse(args[2]))); 
            }
        }
    }
}
