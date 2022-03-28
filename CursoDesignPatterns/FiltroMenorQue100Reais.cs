using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMenorQue100Reais() : base() { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> filtrada = new List<ContaBancaria>();
            foreach (ContaBancaria c in contas)
            {
                if (c.Saldo < 100) filtrada.Add(c);
            }
            foreach (ContaBancaria c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
