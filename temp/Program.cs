using System;
using System.Numerics;

namespace temp
{
    class Program
    {
        static void Main()
        {
            string number = "56738457134614591365734659165734593478561238756178356413658956738571461459136573465916573459";

            BigInteger n = BigInteger.Parse(number);

            int i = 0;
            while(i < 100){
                n *= n;
                i++;
                Console.Write($"{i} ... ");
            }

            Console.WriteLine(n);
        }
    }
}
