using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    abstract class Relatorio
    {
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<ContaBancaria> contas);
        
        public void Imprimir(IList<ContaBancaria> contas)
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
