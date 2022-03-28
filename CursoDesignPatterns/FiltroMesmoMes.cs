using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMesmoMes() : base() { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> filtrada = new List<ContaBancaria>();
            foreach (ContaBancaria c in contas)
            {
                if (c.DataAbertura.Month == DateTime.Now.Month &&
                  c.DataAbertura.Year == DateTime.Now.Year)
                {
                    filtrada.Add(c);
                }
            }

            foreach (ContaBancaria c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
