using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Quando organizamos nosso código dentro de diretórios o C# recupera o nome dele e coloca como parte do namespace
namespace ByteBank.Funcionarios
{
    // A classe Funcionário é uma Abstração para as caracteristicas/funcionalidades compartilhadas entre todos os funcionários
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        // Quando usarmos diretório dentro do código, utilizar o comando Ctrl Ponto (.) para acessar a lista de 
        // possíveis correções para facilitar nossa digitação
        public string Nome { get; set; }

        public string CPF { get; private set; }
        
        // Usamos o protected para poder manipular o Salário dentro das classes filhas, porém, ele deixa o Set privado no Program.cs
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Construtor de FUNCIONARIOS");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        // Colocamos o Abstract em AumentarSalario e GetBonificacao para tornar obritória a implementação desses métodos em classes filhas
        public abstract void AumentarSalario();

        // Método que retorna a Bonificação do Funcionário
        // Adicionamos Virtual para especificar esse método e permitir que a classe filha Diretor o sobrescreva
        // public virtual double GetBonificacao()
        public abstract double GetBonificacao();
    }
}
