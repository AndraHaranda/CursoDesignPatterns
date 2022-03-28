//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CursoDesignPatterns
//{
//     class EmAprovacao : EstadoDeUmOrcamento
//    {
//        public void AplicaDescontoExtra(Orcamento orcamento)
//        {
//            orcamento.Valor += - (orcamento.Valor * 0.05);
//        } 
//        public void Aprova(Orcamento orcamento)
//        {
//            orcamento.EstadoAtual = new Aprovado();
//        }

//        public void Reprova(Orcamento orcamento)
//        {
//            orcamento.EstadoAtual = new Reprovado();
//        }

//    }
//}
