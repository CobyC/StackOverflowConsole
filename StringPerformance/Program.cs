using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringPerformance
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var sum = BenchmarkRunner.Run<DoSomeStuff>();
            //Console.Write(dss.GenerateSaveStringOptimized());
        }       

    }
}
