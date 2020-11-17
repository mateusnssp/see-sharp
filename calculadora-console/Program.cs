using System;

namespace calculadora_console
{
    class Program
    {
        static string Calculate(string modo, double num1, double num2)
        {
            switch (modo.ToUpper())
            {
                case "-h":
                case "--help":
                case "HELP":
                    return "Help";

                case "-S":
                case "--SUM":
                case "SUM":
                    return Convert.ToString(Sum(num1, num2));
                case "-SB":
                case "--SUBTRACTION":
                case "SUBTRACTION":
                    return Convert.ToString(Subtraction(num1, num2));
                case "-M":
                case "--MULTIPLICATION":
                case "MULTIPLICATION":
                    return Convert.ToString(Multiplication(num1, num2));
                case "-D":
                case "--DIVISION":
                case "DIVISION":
                    return Convert.ToString(Division(num1, num2));


                default:
                    return "Error";
            }
        }

        static void Help()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Usage: dotnet [options] [first numeric argument] [second numeric argument]\n");
            Console.WriteLine("Options:");
            Console.WriteLine("\t\t -h|--help                 Display Help.");
            Console.WriteLine("\t\t -s|--sum                  Sum.");
            Console.WriteLine("\t\t-sb|--subtraction          Subtraction.");
            Console.WriteLine("\t\t -m|--multiplication       Multiplication.");
            Console.WriteLine("\t\t -d|--division             Division.");
            Console.WriteLine("\n\n");
            Console.WriteLine("first numeric argument:");
            Console.WriteLine("\t\tAny numeric value intended for calculation.");
            Console.WriteLine("second numeric argument:");
            Console.WriteLine("\t\tSecond numeric value any intended for calculation.");
            Console.WriteLine("\n\n");
        }

        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            if(args.Length == 3)
            {
            string modo = Convert.ToString(args.GetValue(0));
            double num1 = Convert.ToDouble(args.GetValue(1));
            double num2 = Convert.ToDouble(args.GetValue(2));
            Console.WriteLine(Calculate(modo, num1, num2));
            }else{
                Help();
            }
        }
    }
}
