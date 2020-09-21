using System;
using System.Drawing;
using System.Threading.Tasks;

namespace AsyncAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncProcessTesting at = new AsyncProcessTesting();

            AsyncProcessTesting.DoRunProcessAsync().Wait();

            Task.Run(async () => { await AsyncProcessTesting.DoRunProcessAsync(); });
        }
    }


    public class AsyncProcessTesting
    {


        public async static Task DoRunProcessAsync()
        {
            Console.WriteLine("long running process");
            await Task.Delay(2000);
        }


    }
}
