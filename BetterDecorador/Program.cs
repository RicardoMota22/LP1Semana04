using System;
using System.Net;

namespace BetterDecorador
{
    public class Program
    {
        private static string Decor(string s , char dec, int num)
        {
            /*
            string border = new string(dec,num);
            return $"{border}{s}{border}";
            */

            int n = 0;
            s = " " + s + " ";
            while(n != num)
            {
                s = dec + s + dec;
                ++n;
            }
            return s;

        }
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
