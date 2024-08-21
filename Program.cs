using ConcurrentTasks.Exercises;

Console.WriteLine("Escolha o exercício para rodar:");
Console.WriteLine("1 - Exercício 1 com Sleep");
Console.WriteLine("2 - Exercício 1 sem Sleep");
Console.WriteLine("3 - Exercício 2");
Console.WriteLine("");
var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Exercise1.Run(withSleep: true);
        break;
    
    case "2":
        Exercise1.Run(withSleep: false);
        break;

    case "3":
        await Exercise2.Run();
        break;

    default:
        Console.WriteLine("Escolha inválida.");
        break;
}