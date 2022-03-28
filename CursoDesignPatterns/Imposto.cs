using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }  

        //construtor que recebe o outro imposto
        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        //construtor default
        public Imposto()
        {
            this.OutroImposto = null;  
        }

        //trativa caso o proximo imposto não existir 
        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            return (OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento));
        }
        public abstract double Calcula(Orcamento orcamento);

    }
}
