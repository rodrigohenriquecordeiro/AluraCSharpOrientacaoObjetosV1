using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine("Agência: " + conta.Agencia);
            Console.WriteLine("Conta-Corrente: " + conta.Numero);
            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            ContaCorrente contaGabriela = new ContaCorrente(867, 45123698);
            Console.WriteLine("Agência: " + contaGabriela.Agencia);
            Console.WriteLine("Conta-Corrente: " + contaGabriela.Numero);

            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            Console.ReadLine();
        }
    }
}
