/*
//Explicar sobre o programa
//Pedir quantos caracteres ele deseja
//Fazer uma repetição do numero pedido
//Pedir se o mesmo deseja continuar
 */
using System.Security.Cryptography;

bool Continuar = true;
char Caractere = ' ';
int Qtde = 0; // Quantidade de vezes que se repete o numero.
int Resposta = 0;

Console.WriteLine("Boa Tarde, bem-vindo ao repetidor de caracteres\nGostaria que vc informasse quantos caracteres desejas que seja repetido.");
while (Continuar)
{
    Console.Write("\nDigite um número, Por favor: ");
    while(!int.TryParse(Console.ReadLine(), out Qtde)) { Console.Write("\nPor favor, me diga apenas numeros\nNumero: ");}

    Console.Write("\nDigite qualquer caractere que deseje: ");
    while(!char.TryParse(Console.ReadLine(), out Caractere)) { Console.Write("\nPor favor, me diga apenas 1 caractere\nCaractere: ");}
    
    for(int i = 0; i < Qtde; i++){Console.Write(Caractere);}

    Console.WriteLine("\nVocê deseja continuar?\nCaso deseja, escolha o número abaixo\n1 - Sim\n2 - Não");
    while(!int.TryParse(Console.ReadLine(), out Resposta)) { Console.Write("\nPor favor, me diga apenas numeros\nNumero: ");}

    if (Resposta.Equals(1))
    {
        Console.WriteLine("\nFoi um prazer");
    }
    else if (Resposta.Equals(2))
    {
        Console.WriteLine("\nFoi um prazer");
        Continuar = false;
        Resposta = 0;
    }
}
