using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro() { }

        public abstract IList<ContaBancaria> Filtra(IList<ContaBancaria> contas);

        protected IList<ContaBancaria> Proximo(IList<ContaBancaria> contas)
        {
            if (OutroFiltro != null) return OutroFiltro.Filtra(contas);
            else return new List<ContaBancaria>();
        }
    }
}
