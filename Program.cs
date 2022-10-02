
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    /*
     * Boxing and unboxing
     */
    // добавляя упаковку и разпаковку, добавляем время на это и ктому-же с временем нужна будет работа габидж коллектора

    [MemoryDiagnoser]

    public class BoxingTest
    {

        [Benchmark]

        public void NoBoxing()
        {
            int res = 0;
            int a = 1;
            res += a;
        }
        [Benchmark]

        public void Boxing()
        {
            int res = 0;
            object a = 1;
            res = +(int)a;
        }
    }

    class Program
    {
        
        public static void Main(string[] args)
        {
            int a = 1; 
            object b = a; 
            int c = (int)b; 

            //decimal d = (decimal)b; // InvalidCastException // распаковать 1 как decimal, не получится - будет ошибка.

        }
    }
}
