int[] soma = new int[10];
int novasoma = 0;

for(int i = 0; i < soma.Length; i++)
{
    Console.Write("\nPoderia escrever um numero? ");
    int receba = int.Parse(Console.ReadLine()); //Pedi o numero;
    soma[i] = receba; //Colocando o numero pedido na array
    novasoma += soma[i]; //Somando o numero pedido com a soma passada
    Console.WriteLine($"A soma atual é {novasoma}"); //Exibindo
}

