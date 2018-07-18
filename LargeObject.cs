using System;
using System.Collections.Generic;

namespace JsonSerializerBanchmark
{
    public class LargeObject
    {
        public List<Guid> Idis { get; set; } = new List<Guid>();
        public List<InternalClass> Elements { get; set; } = new List<InternalClass>();
        public Guid RequestId { get; set; }
        public string Name { get; set; }
    }
}