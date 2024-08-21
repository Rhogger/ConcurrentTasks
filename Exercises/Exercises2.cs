namespace ConcurrentTasks.Exercises;

public class Exercise2
{
    public async Task Run()
    {
        // Código do exercício 2
        string[] urls = new string[]
        {
            "https://www.google.com",
            "https://www.microsoft.com",
            "https://www.github.com",
            "https://www.stackoverflow.com"
        };

        var tasks = urls.Select(async url =>
        {
            using HttpClient client = new HttpClient();
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            var response = await client.GetAsync(url);
            stopwatch.Stop();
            Console.WriteLine($"URL: {url} - Tempo de Resposta: {stopwatch.ElapsedMilliseconds} ms");
        });

        await Task.WhenAll(tasks);
    }
}