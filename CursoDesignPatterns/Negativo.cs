namespace CursoDesignPatterns
{
	public class Negativo  
    {
        public void Saca(ContaBancaria conta, double valor) 
        {
            throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
        }

        public void Deposita(ContaBancaria conta, double valor) 
        {
            conta.Saldo += valor * 0.95;
        }  
    }
}