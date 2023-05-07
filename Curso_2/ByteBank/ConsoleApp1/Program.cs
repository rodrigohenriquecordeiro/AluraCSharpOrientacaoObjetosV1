using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;
            contaGabriela.saldo = 100;

            Console.WriteLine("Títular: " + contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Número: " + contaGabriela.numero);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            contaGabriela.saldo += 200;
            Console.WriteLine("Novo saldo da Conta: R$ " + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
