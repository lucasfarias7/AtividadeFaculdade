using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvdFaculdade.Entities
{
    public class Supervisor : Funcionario
    {
        
        public Supervisor()
        {
        }

        public Supervisor(string nome, string cpf, double salario, Setor setor) : base(nome, cpf, salario, setor)
        {            
        }

        public override double Bonificacao(double valor)
        {
            if(valor != 50 || valor == 50)
            {
                valor = 100 + 50;
            }
            return base.Bonificacao(valor);
        }
    }
}
