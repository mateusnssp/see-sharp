using System;

//Este programa imprime "Olá, mundo!" no console e caso receba algum argumento para a classe principal, imprime o mesmo.

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tOlá, mundo!");
            if(args.GetLength(0) > 0)
            {
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}
