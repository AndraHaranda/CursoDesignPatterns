using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
     public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicacaoDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçameno já está finalizado");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçameno já está finalizado");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
