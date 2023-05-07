using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 03 - Ponto Flutuante");

            double salario = 1640.30;
            Console.WriteLine($"\nMeu salário: {salario:C}");

            double n = 15 / 2;
            Console.WriteLine(n);   // Um nº inteiro dividido por outro nº inteiro tem como resposta um nº inteiro

            double n2 = 15.0 / 2;
            Console.WriteLine(n2);  // Uma saída é transformar um dos nº em double para a resposta ser um double
            
            Console.WriteLine("\nTecle enter para encerrar.");
            Console.ReadLine();
        }
    }
}
