using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtvdFaculdade.Entities;
using System.Globalization;

namespace AtvdFaculdade
{
    class Program
    {
        static void Main(string[] args)
        {
      
           Console.WriteLine("Informe os dados do Gerente.");
           Console.Write("Nome: ");
           string nome = Console.ReadLine();
           Console.Write("Cpf: ");
           string cpf = Console.ReadLine();
           Console.Write("Salario: ");
           double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           Console.Write("Setor: ");
           string nomeSetor = Console.ReadLine();
           Console.Write("Usuario: ");
           string usuario = Console.ReadLine();
           Console.Write("Senha: ");
           string senha = Console.ReadLine();
            Console.WriteLine();
           Setor setorGer = new Setor(nomeSetor);

           Gerente gerente = new Gerente(nome, cpf, salario, setorGer);
           Gerente Autenticacao = new Gerente(usuario, senha);
           Autenticacao.Autenticacao(usuario, senha);
           gerente.Bonificacao(80);
           gerente.GetSalario();

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Informe os dados do Supervisor.");
           Console.Write("Nome: ");
           nome = Console.ReadLine();
           Console.Write("Cpf: ");
           cpf = Console.ReadLine();
           Console.Write("Salario: ");
           salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           Console.Write("Setor: ");
           nomeSetor = Console.ReadLine();
            Console.WriteLine();

           Setor setorsuper = new Setor(nomeSetor);

           Supervisor super = new Supervisor(nome, cpf, salario, setorsuper);
           super.Bonificacao(100);
           super.GetSalario();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine("Informe os dados do Estagiario.");
           Console.Write("Nome: ");
           nome = Console.ReadLine();
           Console.Write("Cpf: ");
           cpf = Console.ReadLine();
           Console.Write("Salario: ");
           salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           Console.Write("Setor: ");
           nomeSetor = Console.ReadLine();
           Console.Write("Carga horaria (20H ou 40H): ");
           int carga = int.Parse(Console.ReadLine());
            Console.WriteLine();

           Setor setorEst = new Setor(nomeSetor);

           Estagiario Estagiario = new Estagiario(nome, cpf, salario, setorEst, carga);
           Estagiario.Bonificacao(50);
           Estagiario.GetSalario();


            Console.ReadKey();
        

        }
    }
}
