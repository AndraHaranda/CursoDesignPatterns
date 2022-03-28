using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Requisicao
    {
        public Formato formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.formato = formato;
        }
    }
}
