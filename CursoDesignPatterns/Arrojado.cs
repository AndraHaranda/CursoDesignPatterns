using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Arrojado : Investimento
    {
        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }
        public double Calcula(ContaBancaria conta)
        {
            int chances = random.Next(10);
            if (chances >= 0 && chances <= 1)
                return conta.Saldo * 0.5;
            else if (chances >= 2 && chances <= 4)
                return conta.Saldo * 0.3;
            else return conta.Saldo * 0.006;
        }
    }
}