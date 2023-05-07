using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 863;
            contaGabriela.numero = 863452;

            ContaCorrente contaGabrielaCosta = new ContaCorrente();
            contaGabrielaCosta.titular = "Gabriela";
            contaGabrielaCosta.agencia = 863;
            contaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaGabriela == contaGabrielaCosta));

            int idade = 30;
            int outraIdade = 30;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == outraIdade));

            contaGabriela = contaGabrielaCosta;
            Console.WriteLine(contaGabriela == contaGabrielaCosta);

            contaGabrielaCosta.saldo = 300;
            Console.WriteLine(contaGabriela.saldo);
            Console.WriteLine(contaGabrielaCosta.saldo);

            if (contaGabriela.saldo >= 100)
            {
                contaGabriela.saldo -= 100;
            }
            Console.ReadLine();
        }
    }
}
