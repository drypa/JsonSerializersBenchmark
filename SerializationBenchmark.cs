using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using BenchmarkDotNet.Attributes;
using Jil;
using Newtonsoft.Json;

namespace JsonSerializerBanchmark
{
    public class SerializationBenchmark
    {
        private readonly ObjectWithGuid _guidObject;
        private readonly LargeObject _largeObject;

        public SerializationBenchmark()
        {
            _guidObject = new ObjectWithGuid
            {
                Id = Guid.NewGuid()
            };
            _largeObject = LargeObjectFactory.Create(2000);
        }
        
        [Benchmark]
        public string Jil_Serialize_Guid()
        {
            return JSON.Serialize(_guidObject);
        }
        
        [Benchmark]
        public string Newton_Serialize_Guid()
        {
            return JsonConvert.SerializeObject(_guidObject);
        }
        
        [Benchmark]
        public string Jil_Serialize_LargeObject()
        {
            return JSON.Serialize(_largeObject);
        }
        
        [Benchmark]
        public string Newton_Serialize_LargeObject()
        {
            return JsonConvert.SerializeObject(_largeObject);
        }
    }

    public static class LargeObjectFactory
    {
        private static readonly Random Rand = new Random();
        public static LargeObject Create(int count)
        {
            return new LargeObject
            {
                Elements = GetElements(count),
                Idis = GetIdis(count),
                Name = new string('a',128),
                RequestId = Guid.Empty
            };
        }

        private static List<InternalClass> GetElements(int count)
        {
            return Enumerable.Range(0, count).Select(x=>GetElement()).ToList();
        }
        private static List<Guid> GetIdis(int count)
        {
            return Enumerable.Range(0, count).Select(x=>Guid.NewGuid()).ToList();
        }

        private static InternalClass GetElement()
        {
            return new InternalClass
            {
                Count =  Rand.Next(10,99),
                Length = Rand.Next(10,99),
                Name = new string('a',32),
                Radius = Rand.Next(10,99),
                RequestId = Guid.NewGuid()
            };
        }
    }
}