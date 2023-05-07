using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistema;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("528.639.417-54");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario guilherme = new Desenvolvedor("159.149.169-78");
            guilherme.Nome = "Guilherme";

            Funcionario pedro = new Designer("390.811.528-07");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("635.789.412-85");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("741.258.963-45");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("789.654.123-56");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de Bonificações do mês: R$ " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
