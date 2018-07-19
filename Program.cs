using System;
using BenchmarkDotNet.Running;

namespace JsonSerializerBanchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<SerializationBenchmark>();
            Console.ReadLine();
        }
    }
}