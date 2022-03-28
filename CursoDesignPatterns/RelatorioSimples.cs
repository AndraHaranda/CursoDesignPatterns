using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Brasil");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 9999-9999");
        }

        protected override void Corpo(IList<ContaBancaria> contas)
        {
            foreach (ContaBancaria c in contas)
            {
                Console.WriteLine(c.NomeTitular + " - " + c.Saldo);
            }
        }
    }
}

   