using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvdFaculdade.Entities
{
    public abstract class Funcionario
    {
        protected string Nome { get; set; }

        protected string Cpf { get; set; }

        protected double Salario { get; set; }

        protected Setor Setor { get; set; }


        public Funcionario()
        {
        }

        public Funcionario(string nome, string cpf, double salario, Setor setor)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
            this.Setor = setor;
        }


        public virtual double Bonificacao(double valor)
        {
            return this.Salario += valor;
        }

        public void GetSalario()
        {
            Console.WriteLine("O seu salario "+this.Nome+" com a bonificação é: "+this.Salario);
        }
    }
}
