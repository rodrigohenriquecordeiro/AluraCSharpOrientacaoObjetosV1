using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 05 - Caracteres e Textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia";
            Console.WriteLine(titulo);

            Console.ReadLine();
        }
    }
}
