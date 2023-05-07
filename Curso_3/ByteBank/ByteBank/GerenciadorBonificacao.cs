using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        // Sobrecargas do Método Registrar:
        // Método Registrar com argumento de Funcionário e Diretor também (por causa da Herança)
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
