using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvdFaculdade.Entities
{
    public class Estagiario : Funcionario
    {
        public int CargaHoraria { get; set; }

        public Estagiario()
        {
        }

        public Estagiario(string nome, string cpf, double salario, Setor setor, int cargaHoraria) 
            : base(nome, cpf, salario, setor)
        {
            this.CargaHoraria = cargaHoraria;
        }


        public override double Bonificacao(double valor)
        {
            if(valor != 25)
            {
                valor = 100 + 25;
            }
            return base.Bonificacao(valor);
        }
    }
}
