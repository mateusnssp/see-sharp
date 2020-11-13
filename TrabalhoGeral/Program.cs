using System;

/* Faça o programa imprimir "Olá =))" na tela;
 * Faça o programa pegar dois números digitados pelo usuário e entregar a soma entre os mesmos; 
 * Faça o programa verificar e informar ao usuário se a soma, antes obtida, é par ou ímpar; */

namespace TrabalhoGeral
{
    class Program
    {
        static bool Validar_VerificarParOuImpar(string resposta)
        {
            switch (resposta.ToUpper())
            {
                case "S":
                    return true;
                    break;
                default:
                    return false;
            }
        }

        static string VerificarParOuImpar(int soma)
        {
            if(soma % 2 == 0)
            {
                return "Par";
            }else{
                return "Ímpar";
            }
        }

        static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        static void Main()
        {
            Console.WriteLine("\t\tOlá =))\n");
            Console.Write("Informe o primeiro número: "); int num1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: "); int num2 = int.Parse(Console.ReadLine());
            int soma = Soma(num1, num2);
            Console.WriteLine($"A soma entre {num1} e {num2} é igual a {soma}.");

            Console.Write($"Você deseja verificar se {soma} é par ou ímpar? (s/n): "); dynamic resposta = Console.ReadLine();
            resposta = Validar_VerificarParOuImpar(resposta);

            if(resposta)
            {
                Console.WriteLine($"O número {soma} é {VerificarParOuImpar(soma)}.");
            }
        }
    }
}
