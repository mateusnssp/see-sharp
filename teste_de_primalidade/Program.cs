using System;

namespace teste_de_primalidade
{
    class Program
    {
        static bool fun(double n){
            double lim = Math.Sqrt(n);
            Console.WriteLine(lim);
            if(n > 1){
                for(double i = 2; i <= lim; i++){
                    if(n % i == 0){
                        return false;
                    }
                }return true;
            }return false;
        }

        static void Main(string[] args)
        {
            double n = double.Parse(args[0]);
            Console.WriteLine(fun(n));
        }
    }
}
