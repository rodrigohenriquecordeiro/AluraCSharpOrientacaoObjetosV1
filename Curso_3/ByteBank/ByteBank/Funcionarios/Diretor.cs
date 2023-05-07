using ByteBank.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // Diretor passou a herda Autenticavel para poder ter acesso ao sistema
    public class Diretor : FuncionarioAutenticavel
    {
        // O base serve para invocar o método Funcionario na classe base Funcionário
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Construtor de DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        // Adionamos Override para permitir que a classe filha Diretor sobescreva GetBonificação de Funcionários
        public override double GetBonificacao()
        {
            // Diretores recebem 100% de bonificação (um salário novo) + a Bonificação padrão do Funcionário
            // Usamos a Base para acessar o método GetBonificação() de Funcionários e com isso não cair no StackOverlow
            // return Salario + base.GetBonificacao();
            return Salario * 0.5;
        }
    }
}
