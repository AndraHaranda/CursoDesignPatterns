using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto imposto) : base(imposto) { }
        public ICMS() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculaOutroImposto(orcamento);
        }
    }
}
