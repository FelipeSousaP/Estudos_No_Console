//O exercicio apenas pede exibição.

for(int i = 2;  i < 10; i++) //Essa repetição vai 1 vez
{
    Console.WriteLine($"\n*********************\nTabuada de {i}\n*********************");
    for(int j = 0; j < 11; j++) //Essa repetição vai por total
    {
        int total = i * j; 
        Console.WriteLine($"{i} * {j} = {total}");
    }
    // Assim fazendo tudo denovo
}

