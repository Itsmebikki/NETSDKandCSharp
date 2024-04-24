//Parallel programming:
//Multicore: multiple CPUs physically 
//Make use of multiple CPus in parallel
// .NET has TPL(Task Parallel Library)


// Asynchronous programming: Technique to run program asynchronously 
// AJAX- Asynchronous Javasscript and XML
// Non-blocking I/O 
// .NET: async, await
using System;
using System.Threading;
using System.Threading.Tasks;

class ParallelAsync
{
    int[] numbers = [23, 46, 12, 34, 68, 24, 56, 232, 53];

    public void ProcessNumbers()
    {
        // Sequential
        Console.WriteLine("Sequential Implementation");
        foreach(var num in numbers)
        {
            DoWork(num);
        }

        Console.WriteLine("Parallel Implementation");
        Parallel.ForEach(numbers, DoWork);       
    }

    public void DoWork(int num)
    {
        Thread.Sleep(1000); // Simulating delay
        Console.WriteLine($"Num: {num}");
    }

    
    // Making tea
    public async Task IgniteStove()
    {
        await Task.Delay(5000);
    }

    public async Task PutKeatleyOnWithWater()
    {
        await Task.Delay(5000);
    }

    public async Task GrindMasala()
    {   
        await Task.Delay(30000);
    }

    public void PourChiyaPatti()
    {

    }

    public void PourSugar()
    {
        
    }

    public void PourMasala()
    {        
    }

    public void PourMilk()
    {
        
    }
}


