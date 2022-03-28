using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Item
    {
        public String Nome { get; private set; }    
        public double Valor { get; private set; }   

        public Item(String Nome, double Valor)
        {
            this.Nome = Nome;
            this.Valor = Valor;
        }
    }
}
