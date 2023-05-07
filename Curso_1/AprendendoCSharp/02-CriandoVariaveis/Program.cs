using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 02 - Criando Variaveis");

            int idade = 10 + 7;
            int idade2 = 5 + 5;
            double media = (idade + idade2) / 2;
            Console.WriteLine($"\nA média entre as duas idades é: {media}");

            Console.WriteLine("\nExecução finalizada. Tecle enter para finalizar.");
            Console.ReadLine();
        }
    }
}
