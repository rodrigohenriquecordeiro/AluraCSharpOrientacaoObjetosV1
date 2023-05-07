using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Conversoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 04 - Converções e Outros Tipos Númericos\n");

            double salario = 1200.50;
            Console.WriteLine(salario);

            int salarioInteiro = (int)salario;  // Type casting, porém perde-se precisão, após a vírgula os dados são truncados
            Console.WriteLine(salarioInteiro);

            Console.ReadLine();
        }
    }
}
