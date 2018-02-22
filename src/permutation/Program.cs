using System;

namespace permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello permutations!");

            PermutationArrayClient.GetPermutationsWithReptTest();
            PermutationArrayClient.GetPermutationstTest();
            PermutationArrayClient.GetKCombsWithReptTest();
            PermutationArrayClient.GetKCombsTest();

            Console.WriteLine("Done permutations!");
            Console.ReadKey();
        }

    }
}
