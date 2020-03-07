using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvdFaculdade.Entities
{
    public class Setor
    {
        public string NomeSetor { get; set; }


        public Setor()
        {
        }

        public Setor(string nomeSetor)
        {
            this.NomeSetor = nomeSetor;
        }
    }
}
