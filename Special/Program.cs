using System;
using System.Threading;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int special = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(special));
            GetSpecial(0);
        }
        /*
        private static ulong Factorial(ulong n)
        {
        ulong fact ;
        if (n==1) // Caso base
        fact = 1;
        else // Caso geral
        fact =n * Factorial(n - 1);
        return fact ;
        }
        */
        private static int GetSpecial(int n)
        {
            int special;
            if(n == 0)
            {
                special = 0;
            }
            else if (n == 1)
            {
                special = 1;
            }
            else
            {
                special = GetSpecial(n-1) + (2 * GetSpecial(n-2));
            }
            return special;
        }
       

    }
}
