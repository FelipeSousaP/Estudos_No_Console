namespace Banco
{
    public class Conta
    {
        private double Saldo;
        

        public double Deposito(double amount)
        {
            if (amount > 0) 
            {
                Saldo += amount;
                Console.WriteLine($"Deposito realizado: {Saldo}");
            }
            return Saldo;
        }

        public double Saque(double amount)
        {
            if (amount > 0)
            {
                if (Saldo >= amount) 
                {
                    Saldo -= amount;
                    Console.WriteLine($"Saque realizado: {Saldo}");
                }
                else
                {
                    Console.WriteLine("Informe direito, animal");
                }
            }
            return Saldo;
        }
    }
}
