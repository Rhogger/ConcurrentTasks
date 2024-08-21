namespace ConcurrentTasks.Exercises;

public class Exercise2
{
    public static async Task Run()
    {
        var urls = new[]
        {
            "https://www.google.com",
            "https://www.microsoft.com",
            "https://www.github.com",
            "https://www.stackoverflow.com"
        };

        var tasks = urls.Select(async url =>
        {
            using var client = new HttpClient();
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            await client.GetAsync(url);
            stopwatch.Stop();
            Console.WriteLine($"URL: {url} - Tempo de Resposta: {stopwatch.ElapsedMilliseconds} ms");
        });

        await Task.WhenAll(tasks);
    }
}