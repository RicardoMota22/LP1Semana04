using System;

namespace BetterDecorador
{
    public class Program
    {
        private static string Decor(string s , char dec, int num)
        {
            return $"{dec}{dec}{dec} {s} {dec}{dec}{dec}";
        }
        private static void Main(string[] args)
        {
            Console.WriteLine (Decor("Good Morning!", '*', 3));
            Console.WriteLine (Decor("Good Evening !", '.',2));
        }
    }
}
