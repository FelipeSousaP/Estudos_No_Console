using Escola;

Professor P = new();
Aluno aluno = new();

#region Consulta do professor
P.GENERO = Console.ReadLine();
P.NAME = Console.ReadLine();
P.IDADE = int.Parse(Console.ReadLine());

Console.WriteLine($"Os dados são {P.IDADE} {P.NAME} {P.GENERO}");
#endregion

#region Consulta do Aluno
aluno.GENERO = Console.ReadLine();
aluno.NAME = Console.ReadLine();
aluno.IDADE = int.Parse(Console.ReadLine());

Console.WriteLine($"Os dados são {aluno.IDADE} {aluno.NAME} {aluno.GENERO}");
#endregion
