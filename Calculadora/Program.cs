using Calculo;

//variaveis
int N1 = 0;
int N2 = 0;
bool continuar = true;
Operações operações = new();

Console.WriteLine("\nBem vindo a calculadora do Console\nPoderia selecionar a operação desejada e os números da operação\n");
while (continuar)
{
    Console.Write("\nPorfavor, Digite o numero inteiro: ");
    while (!int.TryParse(Console.ReadLine(),out N1)) {Console.Write("\nPor favor digite corretamente: ");}
    Console.Write("\nPorfavor, Digite o numero inteiro: ");
    while (!int.TryParse(Console.ReadLine(),out N2)) {Console.Write("\nPor favor digite corretamente: ");}

    Console.WriteLine("A = adição;\nS = Subtração;\nD = Divisão;\nM = Multiplicação");
    Console.Write("Operação:");
/*
    OperaçãoEscolhida = Console.ReadKey().Key;

    if(OperaçãoEscolhida == ConsoleKey.A)
        operações.Soma(N1, N2);
    else if(OperaçãoEscolhida == ConsoleKey.S)
        operações.Subtração(N1, N2);
    else if(OperaçãoEscolhida == ConsoleKey.D)
        operações.Divisão(N1, N2);
    else if(OperaçãoEscolhida == ConsoleKey.M)
        operações.Multiplicação(N1, N2);
*/
}
