using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            Desconto d1 = new DescontosPorCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto d3 = new SemDesconto();
            Desconto d4 = new DescontoPorVendaCasada(); 

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);

        }
    }
}
