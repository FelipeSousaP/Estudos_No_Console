using Banco;

Conta conta = new Conta();
double Deposito = 0;
double saque = 0;

Console.Write("\nInforme o deposito desejado?");
while(!double.TryParse(Console.ReadLine(), out Deposito))
{
    Console.WriteLine("Informe direito animal");
}
conta.Deposito(Deposito);


Console.Write("\nInforme o Saque desejado?");
while (!double.TryParse(Console.ReadLine(), out saque))
{
    Console.WriteLine("Informe direito animal");
}
conta.Saque(saque);