using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(ContaBancaria conta, Investimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            conta.Saldo(resultado * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}

