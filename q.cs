using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long add = 0;
            var st = System.DateTime.Now;

            for (int index = 0; index <= 100000000; index++)
            {
                add = add + index;
            }

            var ed = System.DateTime.Now - st;

            Console.WriteLine($"MachineName - {System.Environment.MachineName}");
            Console.WriteLine($"OSVersion - {System.Environment.OSVersion}");
            Console.WriteLine($"UtcNow - {System.DateTime.UtcNow}");
            Console.WriteLine("==========================");
            Console.WriteLine("C# 테스트");
            Console.WriteLine(add);
            Console.WriteLine(ed);
            Console.WriteLine("==========================");
        }
    }
}
