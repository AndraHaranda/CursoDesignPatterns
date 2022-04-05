using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ContaBancaria
    {
        public string NomeTitular { get;  set; } 
        public double Saldo { get; set; }
        public DateTime DataAbertura { get;  set; }
      
        public ContaBancaria(string titular, double saldo)
        {
            this.NomeTitular = titular;
            this.Saldo = saldo;
        }
        public interface IEstadoDaConta
        {
            void Saca(ContaBancaria c, double valor);
            void Deposita(ContaBancaria c, double valor);
        }
        public class Positivo : IEstadoDaConta
        {
            public void Saca(ContaBancaria c, double valor) 
            { 
                c.Saldo -= valor;
            }
            public void Deposita(ContaBancaria c, double valor) 
            {
                c.Saldo += valor;
            }
        }
    } 
}

