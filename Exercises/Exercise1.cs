using System.Collections.Concurrent;

namespace ConcurrentTasks.Exercises;

public class Exercise1
{
    public void Run(bool withSleep)
    {
        // Código do exercício 1
        var queue = new ConcurrentQueue<int>();
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        int sum = 0;

        var producerTask = Task.Run(() =>
        {
            var random = new Random();
            while (!token.IsCancellationRequested)
            {
                int number = random.Next(1, 101);
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
                if (queue.TryDequeue(out int number))
                {
                    int previousSum = sum;
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