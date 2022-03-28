using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class FiltroMaiorQue500MilReais : Filtro
    {
        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMaiorQue500MilReais() : base() { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> filtrada = new List<ContaBancaria>();
            foreach (ContaBancaria c in contas)
            {
                if (c.Saldo > 500000) filtrada.Add(c);
            }
            foreach (ContaBancaria c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
