using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        public static void Main(string[] args)
        {

            bool finish = false;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine("Digite o Primeiro numero");
                int num1 = int.Parse(Console.ReadLine());
                string operação = Console.ReadLine();
                Console.WriteLine("Digite o segundo numero");
                int num2 = int.Parse(Console.ReadLine());

                int resultado = 0;

                switch (operação)
                {
                    case "+":
                        resultado = num1 + num2;
                        break;

                    case "-":
                        resultado = num1 - num2;
                        break;

                    case "*":
                        resultado = num1 + num2;
                        break;

                    case "/":
                        resultado = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Erro de Operação!");
                        break;
                }
                Console.Clear();
                Console.WriteLine($"{num1} {operação} {num2} = {resultado}");
                Console.WriteLine("Deseja fazer outra conta? s/n");
                char DeNovo = char.Parse(Console.ReadLine());

                if (DeNovo == 's')
                {
                    finish = true;
                }

                else
                {
                    finish = false;
                }

            }
            while( finish );
            Console.WriteLine("Muito Obrigado! Até logo!");
            Console.ReadKey();



        }
    }
}
