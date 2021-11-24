using System;
using System.Diagnostics;
using System.Threading.Tasks;
using CakeMachine.Dataflow;
using CakeMachine.Dataflow.Settings;
using Microsoft.Extensions.Configuration;

namespace CakeMachine.ConsoleApp
{
    class Program
    {
        private static async Task Main()
        {
            // Seconds case
            // Total cake = 200
            var total = 200;
            var stock = new Stock(total);
            var durationType = DurationType.Seconds;
            var cakeMachine = CakeMachineFactory.GetCakeMachine(durationType);
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            await cakeMachine.RunAsync(stock);
            stopWatch.Stop();

            Console.WriteLine($"Initial stock: {total} - Final stock: {stock.Size}");
            Console.WriteLine($"Elapsed time: {stopWatch.Elapsed}");
            Console.WriteLine("\nPress any key to exit ..");
            Console.ReadKey();

            
        }
    }
}

