using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ContaBancaria
    {
        public String NomeTitular { get; private set; } 
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }  
        


        public ContaBancaria(String titular, double saldo)
        {
            this.NomeTitular = titular;
            this.Saldo = saldo;
        }
        
    }
}
