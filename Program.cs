using ConcurrentTasks.Exercises;

Console.WriteLine("Escolha o exercício para rodar:");
Console.WriteLine("1 - Exercício 1 com Sleep");
Console.WriteLine("2 - Exercício 1 sem Sleep");
Console.WriteLine("3 - Exercício 2");
var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        var exercise1_1 = new Exercise1();
        exercise1_1.Run(withSleep: true);
        break;
    
    case "2":
        var exercise1_2 = new Exercise1();
        exercise1_2.Run(withSleep: false);
        break;

    case "3":
        var exercise2 = new Exercise2();
        await exercise2.Run();
        break;

    default:
        Console.WriteLine("Escolha inválida.");
        break;
}