using System.Collections.Concurrent;

namespace ConcurrentTasks.Exercises;

public class Exercise1
{
    public static void Run(bool withSleep)
    {
        var queue = new ConcurrentQueue<int>();
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        var sum = 0;

        var producerTask = Task.Run(() =>
        {
            var random = new Random();
            while (!token.IsCancellationRequested)
            {
                var number = random.Next(1, 101);
                queue.Enqueue(number);
                Console.WriteLine($"Número gerado: {number}");

                if (withSleep)
                {
                    Thread.Sleep(500);
                }
            }
        }, token);

        var consumerTask = Task.Run(() =>
        {
            while (!token.IsCancellationRequested)
            {
                if (queue.TryDequeue(out var number))
                {
                    var previousSum = sum;
                    sum += number;
                    Console.WriteLine($"{previousSum} + {number} = {sum}");
                }

                if (withSleep)
                {
                    Thread.Sleep(300);
                }
            }
        }, token);

        Console.WriteLine("Pressione qualquer tecla para parar o benchmark...");
        Console.ReadKey();
        cts.Cancel();

        Task.WaitAll(producerTask, consumerTask);
        Console.WriteLine($"Soma final: {sum}");
    }
}