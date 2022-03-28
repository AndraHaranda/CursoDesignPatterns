using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            bool verificaItens = orcamento.Itens.Any(item => item.Nome.Equals("CANETA") || item.Nome.Equals("LAPIS"));
            if (verificaItens)
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
            
        }
    }
}
