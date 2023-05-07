using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 13 - FOR Encadeado\n");

            for (int contadorLinha = 1; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 1; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}