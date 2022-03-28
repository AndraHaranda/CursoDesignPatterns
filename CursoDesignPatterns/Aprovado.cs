using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
     class Aprovado
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor += - (orcamento.Valor * 0.02);
        }
    }
}
