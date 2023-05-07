using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    // Criamos essa interface para poder controlar quem poder acessar o sistema
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
