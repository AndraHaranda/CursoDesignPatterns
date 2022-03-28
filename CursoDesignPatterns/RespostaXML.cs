using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
     class RespostaXML : Resposta
    {
        public Resposta OutraResposta { get; private set; }

        public void Responde(Requisicao req, ContaBancaria conta)
        {
            if (req.formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.NomeTitular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
