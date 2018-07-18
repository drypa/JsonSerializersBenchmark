using System;

namespace JsonSerializerBanchmark
{
    public class InternalClass
    {
        public Guid RequestId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int Radius { get; set; }
        public long? Length { get; set; }
    }
}