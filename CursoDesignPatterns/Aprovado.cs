using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
       public void AplicacaoDescontoExtra(Orcamento orcamento)
        {
            if(!descontoAplicado) 
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else 
            {
                throw new Exception("Desconto já aplicado!");
            }
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception ("Orçamento já está em estado de aprovação");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em APROVADO, não pode ser REPROVADO agora");
        }
         public void Finaliza(Orcamento orcamento)
        {
           orcamento.EstadoAtual = new Finalizado();
        }

        
    }
}
