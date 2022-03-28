using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class RelatorioComplexo : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Banco Brasil");
            Console.WriteLine("Lugar Nenhum, 1234");
            Console.WriteLine("(11) 1111-1111");
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@bancobrasil.com.br");
            Console.WriteLine(DateTime.Now);
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
