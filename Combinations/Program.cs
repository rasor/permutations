using System;

namespace Combinations
{ 
    /// <summary>
    /// Combinations Without Repetion
    /// https://math.stackexchange.com/questions/2449850/listing-every-single-possibility-of-combinations-without-repetition-of-20-elemen
    /// https://www.hackmath.net/en/calculator/combinations-and-permutations?n=4&k=2&order=0&repeat=0
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Combinations!");
            var client = new LoopExisting2dArrayClient();
            client.LoopArray();

            Console.WriteLine("Done Combinations!");
            Console.ReadKey();
        }
    }
}
