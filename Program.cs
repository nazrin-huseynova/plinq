using System.Diagnostics;

namespace AsyncTask;
//public class Employee 
//{
//public int Id { get; set; }
//    public string Name { get; set; } = "";
//    public string Department { get; set; } = "";    
//    public int Salary { get; set; }
//}
public class Program
{
    static void Main(string[] args)
    {
        #region EXAMPLE ONE
        //var numbers = Enumerable.Range(1, 5_000_000).ToArray();
        // var sw = Stopwatch.StartNew();
        // var sequental = numbers
        //     .Where(x => IsHeavy(x))
        //     .Select(x => x * x)
        //     .ToArray();
        // sw.Stop();
        // Console.WriteLine($"Sequental: {sw.ElapsedMilliseconds} ms");

        // sw.Restart();
        // var paralel =numbers
        //     .AsParallel()
        //     .Where(x => IsHeavy(x))
        //     .Select(x => x * x)
        //     .ToArray();
        // sw.Stop();
        // Console.WriteLine($"Sequental: {sw.ElapsedMilliseconds} ms");

        //var numbers = Enumerable.Range(1, 20);
        //var unordered = numbers
        //    .AsParallel()
        //    .AsOrdered()
        //    .Select(x => $"{x} - > {x * 10}");
        //Console.WriteLine("Unordered:");
        //foreach (var item in unordered)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region EXAMPLE TWO
        //var employees = Enumerable.Range(1, 100000)
        //    .Select(x => new Employee
        //    {
        //        Id = x,
        //        Name = $"Employee - {x}",
        //        Salary = x % 3 == 0 ? 3000 : 7000,
        //        Department = x % 2 == 0 ? "It" : "HR",

        //    });
        //var sw = Stopwatch.StartNew();
        //var highSalaryNames = employees
        //    //.AsParallel()
        //    .Where(e => e.Salary > 5000)
        //    .Select(e => e.Name)
        //    .Take(10)
        //    .ToList();
        //sw.Stop();
        //Console.WriteLine($"Time taken: {sw.ElapsedMilliseconds} ms");
        //foreach (var name in highSalaryNames)
        //{
        //    Console.WriteLine(name);
        //}
        #endregion

        #region EXAMPLE THREE
        //long result = Enumerable.Range(1, 10000)
        //    .AsParallel()
        //    .WithDegreeOfParallelism(Environment.ProcessorCount)
        //    .Where(x => x % 2 == 0)
        //    .Sum(x =>x);
        #endregion

        #region EXAMPLE FOUR
        //using var cts = new CancellationTokenSource();
        //cts.CancelAfter(1000); // Cancel after 100 milliseconds
        //try 
        //{ 
        // var result = Enumerable.Range(1, 10000)
        //    .AsParallel()
        //    .WithCancellation(cts.Token)
        //    .Where(x => IsHeavy(x))
        //    .Sum(x => x);
        //    Console.WriteLine($"Result: {result}");
        //}
        //catch (OperationCanceledException)
        //{
        //    Console.WriteLine("Operation was cancelled.");
        //}
        #endregion
    }

    //static bool IsHeavy(int x)
    //{
    //    double result = 0;
    //    for (int i = 0; i < 100; i++)
    //    {
    //        result += Math.Sqrt(i) + Math.Sin(x);
    //    }
    //    return result > 0;
    //}
}
