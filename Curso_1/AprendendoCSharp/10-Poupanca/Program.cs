using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 10 - Calculadora de Poupança\n");

            double valorInvestido = 1000; int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido *= 1.0036;
                if (contadorMes == 1)
                {
                    Console.WriteLine($"Após {contadorMes} mês, você terá: {valorInvestido:C}.");
                    contadorMes++;
                }
                else
                {
                    Console.WriteLine($"Após {contadorMes} meses, você terá: {valorInvestido:C}."); 
                    contadorMes++;
                }
            }
            Console.ReadLine();
        }
    }
}