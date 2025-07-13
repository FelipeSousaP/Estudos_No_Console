using Calculo;

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

    Console.WriteLine("\nA = adição;\nS = Subtração;\nD = Divisão;\nM = Multiplicação");
    Console.Write("Operação:");

    //O "ConsoleKey" tem um problema, ele utiliza o teclado como biblioteca, ou seja dependendo do modelo do computador ou forma de Abnt
    //O programa não funciona, pois o codigo não considera, além disso, ConsoleKey aparentemente le tudo em Upper.
    char OperaçãoEscolhida = Console.ReadKey().KeyChar;
    OperaçãoEscolhida = char.ToUpper(OperaçãoEscolhida);

    switch (OperaçãoEscolhida)
    {
        case 'A':
            int resultado = operações.Soma(N1, N2);
            Console.WriteLine($"\nA operação foi {resultado}");
            break;
        case 'S':
            int resultado2 = operações.Subtração(N1, N2);
            Console.WriteLine($"\nA operação foi {resultado2}");
            break;
        case 'D':
            int resultado3 = operações.Divisão(N1, N2);
            Console.WriteLine($"\nA operação foi {resultado3}");
            break;
        case 'M': 
            int resultado4 = operações.Multiplicação(N1, N2);
            Console.WriteLine($"\nA operação foi {resultado4}");
            break;
        default:
            Console.WriteLine("\nPor favor, Digite Corretamente!!!");
        break;
    }

    Console.WriteLine("Deseja continuar?\nS = sim\nN = não");
    char pergunta = Console.ReadKey().KeyChar;
    pergunta = char.ToUpper(pergunta);

    if(pergunta == 'S'){ continuar = true; }
    else if(pergunta == 'N'){ continuar = false; }
    else { Console.WriteLine("Da o cu"); Environment.Exit(0); }

    Console.Clear();
}
