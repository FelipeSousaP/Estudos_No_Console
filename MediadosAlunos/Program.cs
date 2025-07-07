using MediaAlunos;

Media media = new();
float Nota1 = 0;
float Nota2 = 0;

//Informar o intuito do programa
Console.WriteLine("Boa tarde\nBem vindo ao calculador de medias\nO senhor poderia informa a média do seu alunos");

//Pedir a media e fazer com que seja apenas numeros, quando for uma letra, ele pedira de volta.
Console.Write("\nA primeira nota do aluno: ");
while(!float.TryParse(Console.ReadLine(), out Nota1))
{
    Console.WriteLine("\nUma letra não é um numero");
    Console.Write("Poderia informar o valor numérico, por favor: ");
}

Console.Write("\nA segunda nota do aluno: ");
while (!float.TryParse(Console.ReadLine(), out Nota2))
{
    Console.WriteLine("\nUma letra não é um numero");
    Console.Write("Poderia informar o valor numérico, por favor: ");
}

//fazer o calculo da media
float MediaTotal = media.Soma(Nota1, Nota2);

//Informar se passou ou não
if(MediaTotal >= 6)
{
    Console.WriteLine("Parabens, voce passou!");
}
else
{
    Console.WriteLine("Tranque o curso, AGR!!!!!!");
}
