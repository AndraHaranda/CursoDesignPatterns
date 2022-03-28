using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class RespostaPorcento : Resposta
    {
        private Resposta OutraResposta { get; set; }

        public RespostaPorcento(Resposta OutraResposta)
        {
            this.OutraResposta = OutraResposta; 
        }
        public RespostaPorcento()
        {
            this.OutraResposta = null;
        }
        public void Responde(Requisicao req, ContaBancaria conta)
        {
            if (req.formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.NomeTitular + "%" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }


            throw new Exception("Resposta inválda");
        }
        
    }
}
