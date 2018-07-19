# JsonSerializersBenchmark



``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.492 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3312641 Hz, Resolution=301.8739 ns, Timer=TSC
.NET Core SDK=2.1.202
  [Host]     : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT


```
|                         Method |           Mean |          Error |         StdDev |
|------------------------------- |---------------:|---------------:|---------------:|
|             Jil_Serialize_Guid |       247.7 ns |       4.973 ns |       7.742 ns |
|          Newton_Serialize_Guid |       630.1 ns |      12.664 ns |      11.846 ns |
|      Jil_Serialize_LargeObject | 1,507,806.0 ns |  30,310.170 ns |  36,082.101 ns |
|   Newton_Serialize_LargeObject | 4,159,659.8 ns |  76,595.124 ns |  67,899.575 ns |
|           Jil_Deserialize_Guid |       253.5 ns |       5.129 ns |      11.259 ns |
|        Newton_Deserialize_Guid |     1,415.6 ns |      25.464 ns |      21.264 ns |
|    Jil_Deserialize_LargeObject | 2,613,964.8 ns |  51,063.727 ns |  79,500.071 ns |
| Newton_Deserialize_LargeObject | 7,096,095.2 ns | 141,870.189 ns | 132,705.450 ns |
