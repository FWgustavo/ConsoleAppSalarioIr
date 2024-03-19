using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalarioIr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a forma de contratação do funcionário((A)Assalariado,(C)Comissionado,(H)Horista: ");
            string contratacao = Console.ReadLine().ToUpper();
            double sb = 0;
            switch (contratacao)
            {
                case "A":
                    Console.WriteLine("Digite o valor do salário bruto: ");
                     sb = double.Parse(Console.ReadLine());

                  
                break;

                case "C":
                    Console.WriteLine("Insira o valor que o funcionário ganha por peça: ");
                    double vp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Quantas peças o funcionário vendeu: ");
                    int quantp = int.Parse(Console.ReadLine());

                     sb = quantp * vp;
                    Console.WriteLine("Seu salário bruto é de: " + sb);
                break;
                
                case "H":
                    Console.WriteLine("Insira o valor por hora: ");
                    double vh = double.Parse(Console.ReadLine());
                    Console.WriteLine("Quantidade de horas trabalhadas: ");
                    int quanth = int.Parse(Console.ReadLine());

                    sb = quanth * vh;
                    Console.WriteLine("Seu salário bruto é de: " + sb);
                break;

                default: 
                    Console.WriteLine("Opção inválida");
                break;

            }
            if (sb <= 2000)
            {
                double sl = sb - sb * 0.075;
                Console.WriteLine("O seu ´salário é de: " + sl);
            }
            else if (sb <= 4000)
            {
                double sl = sb - sb * 0.12;
                Console.WriteLine("O seu salário é de: " + sl);
            }
            else
            {
                double sl = sb - sb * 0.15;
                Console.WriteLine("O seu salário é de: " + sl);
            }
            Console.ReadKey();
        }
    }
}
