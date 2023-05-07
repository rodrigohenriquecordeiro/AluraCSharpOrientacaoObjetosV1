using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 11 - Poupança Parte 2\n");

            double valorInvestido = 1000;
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                if (contadorMes == 1) Console.WriteLine($"Após {contadorMes} mês, você terá: {valorInvestido:C}.");
                else Console.WriteLine($"Após {contadorMes} meses, você terá: {valorInvestido:C}.");
            }
            Console.ReadLine();
        }
    }
}