using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvdFaculdade.Entities
{
    public class Gerente : Funcionario
    {
        public string Usuario { get; set; }

        public string Senha { get; set; }


        public Gerente()
        {
        }

        public Gerente(string nome, string cpf, double salario, Setor setor) : base(nome, cpf, salario, setor)
        {           
        }

        public Gerente(string usuario, string senha)
        {           
            this.Usuario = usuario;
            this.Senha = senha;
        }

        

        public void Autenticacao(string usuario, string senha)
        {
            if(usuario == this.Usuario && senha == this.Senha)
            {
                Console.WriteLine("Autenticacao Sucesso!");
            }
            else
            {
                Console.WriteLine("Dados incorretos");
            }
        }


        public override double Bonificacao(double valor)
        {
            
            if(valor != 100)
            {
                valor = 100 + 100;
            }
            return base.Bonificacao(valor);
        }



    }
}
