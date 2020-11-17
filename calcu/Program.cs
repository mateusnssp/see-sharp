using System;

namespace calcu
{
    class Program
    {
        static string Calculate(string modo, double num1, double num2)
        {
            switch (modo.ToUpper())
            {
                case "H": case "-H": case "--HELP": case "HELP":
                    return "Help";
                case "S": case "-S": case "--SUM": case "SUM":
                    return Convert.ToString(Sum(num1, num2));
                case "SB": case "-SB": case "--SUBTRACTION": case "SUBTRACTION":
                    return Convert.ToString(Subtraction(num1, num2));
                case "M": case "-M": case "--MULTIPLICATION": case "MULTIPLICATION":
                    return Convert.ToString(Multiplication(num1, num2));
                case "D": case "-D": case "--DIVISION": case "DIVISION":
                    return Convert.ToString(Division(num1, num2));


                default:
                    return "help";
            }
        }

        static void Help()
        {
            string msg = "\n\n\nUsage: calcu [options] [first numeric argument] [second numeric argument]\n\nOptions:\n\t\t -h|--help                 Display Help.\n\t\t -s|--sum                  Sum.\n\t\t-sb|--subtraction          Subtraction.\n\t\t -m|--multiplication       Multiplication.\n\t\t -d|--division             Division.\n\n\nfirst numeric argument:\n\t\tAny numeric value intended for calculation.\nsecond numeric argument:\n\t\tSecond numeric value any intended for calculation.\n\n\n";
            Console.WriteLine(msg);
        }

        static double Sum(double num1, double num2){return num1 + num2;}

        static double Subtraction(double num1, double num2){return num1 - num2;}

        static double Multiplication(double num1, double num2){return num1 * num2;}

        static double Division(double num1, double num2){return num1 / num2;}

        static void Main(string[] args)
        {
            if(args.Length == 3)
            {
                try
                {
                    string modo = Convert.ToString(args.GetValue(0));
                    double num1 = Convert.ToDouble(args.GetValue(1));
                    double num2 = Convert.ToDouble(args.GetValue(2));
                    string calc = Calculate(modo, num1, num2);
                    if(calc == "help")
                    {
                        Help();
                    }
                    else
                    {
                        Console.WriteLine(Calculate(modo, num1, num2));
                    }
                }
                catch
                {
                    Help();
                }
            }
            else
            {
                Help();
            }
        }
    }
}
