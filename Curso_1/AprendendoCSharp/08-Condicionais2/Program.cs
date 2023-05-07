using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 08 - Condicionais 2");

            int idadeJoao = 14; int quantidadePessoas = 2;
            bool podeEntrar = idadeJoao >= 18 || quantidadePessoas >= 2;

            if (podeEntrar == true) Console.WriteLine("João pode entrar.");
            else Console.WriteLine("João não pode entrar.");
            
            Console.ReadLine();
        }
    }
}