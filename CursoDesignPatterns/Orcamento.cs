using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public EstadoDeUmOrcamento EstadoAtual { get; set; }
        public double Valor { get;  set; }
        public IList<Item> Itens { get; private set; }
        public Orcamento(double valor)  //construtor
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }
        public void AplicacaoDescontoExtra()
        {
            EstadoAtual.AplicacaoDescontoExtra(this);
        }     
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
        public void Aprova() 
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova() 
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza() 
        {
            EstadoAtual.Finaliza(this);
        }
   
    }
}
