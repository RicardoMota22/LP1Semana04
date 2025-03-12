using System;

namespace BetterDecorador
{
    public class Program
    {
        private static string Decor(string s , char dec, int num)
        {
            string border = new string(dec,num);
            
            return $"{border} {s} {border}";
        }
        private static void Main(string[] args)
        {
            
            Console.WriteLine (Decor("Good Morning!", '*', 3));
            Console.WriteLine (Decor("Good Evening !", '.',2));
        }
    }
}
