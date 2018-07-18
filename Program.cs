using System;
using BenchmarkDotNet.Running;

namespace JsonSerializerBanchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SerializationBenchmark>();
            Console.ReadLine();
        }
    }
}