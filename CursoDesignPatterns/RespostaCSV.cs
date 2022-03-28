using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
     class RespostaCSV : Resposta
    {
        public Resposta OutraResposta { get; private set; }

        public void Responde(Requisicao req, ContaBancaria conta)
        {
            if (req.formato == Formato.CSV)
            {
                Console.WriteLine(conta.NomeTitular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
