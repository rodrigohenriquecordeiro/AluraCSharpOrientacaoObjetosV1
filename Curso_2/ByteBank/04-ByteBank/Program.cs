using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            bool resultadoSaque = contaBruno.Sacar(500);

            Console.WriteLine("Saldo da Conta Corrente do Bruno: R$ " + contaBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaBruno.Depositar(500);
            Console.WriteLine("Saldo da Conta do Bruno: R$ " + contaBruno.saldo);

            contaBruno.Sacar(75);
            Console.WriteLine("Saldo da Conta do Bruno: R$ " + contaBruno.saldo);

            ContaCorrente contaGabriela = new ContaCorrente();
            contaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo Antes da Transferência");
            Console.WriteLine("Saldo do Bruno: R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + contaGabriela.saldo);

            Console.WriteLine("Saldo depois da Transferência");
            bool resultadoTransferencia = contaBruno.Transferir(200, contaGabriela);
            Console.WriteLine("Saldo do Bruno: R$ " + contaBruno.saldo);
            Console.WriteLine("Saldo da Gabriela: R$ " + contaGabriela.saldo);
                        
            Console.ReadLine();
        }
    }
}
