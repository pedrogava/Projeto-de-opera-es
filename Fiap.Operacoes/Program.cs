using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Operacoes
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("digite seu nome:");
                string nome = Console.ReadLine();
                
                Console.WriteLine("Digite um numero:");
                double num1 = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite um segundo numero:");
                double num2 = double.Parse(Console.ReadLine());
                
                double soma = num1+ num2;
                double subitracao = num1- num2;
                double mutiplicacao = num1* num2;
                double divisao = num1/ num2;


                Console.WriteLine("\n Resultados das operações");

                Console.WriteLine($"O valor da soma é {soma}");
                Console.WriteLine($"O valor da subitracao é {subitracao}");
                Console.WriteLine($"O valor da mutiplicacao é {mutiplicacao}");
                Console.WriteLine($"O valor da divisao é {divisao}");

                Console.WriteLine("\n Comparação ente numeros");
                Console.WriteLine($"Os numeros são iguais? {num1 == num2}");
                Console.WriteLine($"Os numeros são diferntes? {num1 != num2}");
                Console.WriteLine($"O primeiro numero é maior que o segundo? {num1 > num2}");

                bool ambosPositivos = num1 >0 && num2 >0;
                bool nenhumNegativo = !(num1 <0 || num2 < 0);
                Console.WriteLine($"Ambos positivos?{ambosPositivos}");
                Console.WriteLine($"Nenhum negativo? {nenhumNegativo}");


            }
            catch (Exception ex) 
            { 

                Console.WriteLine(ex.Message);
            }


        }

    }
}
