using System;

namespace permutation
{
    static class PermutationArrayClient
    {
        /// <summary>
        /// Works, when all digits differs
        /// </summary>
        private static int[] Value = new int[] { 1, 2, 3 };

        public static void GetPermutationsWithReptTest()
        {
            var toPrint = String.Concat<int>(Value);
            Console.WriteLine("GetPermutationsWithRept [" + toPrint + "]");

            var unorderedPermutationsList = PermutationArray.GetPermutationsWithRept(Value, Value.Length);
            var count = 0;
            foreach (var row in unorderedPermutationsList)
            {
                toPrint = String.Concat<int>(row);
                Console.WriteLine("[" + toPrint + "]");
                count++;
            }
            Console.WriteLine("Total: " + count);
        }
        public static void GetPermutationstTest()
        {
            var toPrint = String.Concat<int>(Value);
            Console.WriteLine("GetPermutationstTest [" + toPrint + "]");

            var unorderedPermutationsList = PermutationArray.GetPermutations(Value, Value.Length);
            var count = 0;
            foreach (var row in unorderedPermutationsList)
            {
                toPrint = String.Concat<int>(row);
                Console.WriteLine("[" + toPrint + "]");
                count++;
            }
            Console.WriteLine("Total: " + count);
        }
        public static void GetKCombsWithReptTest()
        {
            var toPrint = String.Concat<int>(Value);
            Console.WriteLine("GetKCombsWithReptTest [" + toPrint + "]");

            var unorderedPermutationsList = PermutationArray.GetKCombsWithRept(Value, Value.Length);
            var count = 0;
            foreach (var row in unorderedPermutationsList)
            {
                toPrint = String.Concat<int>(row);
                Console.WriteLine("[" + toPrint + "]");
                count++;
            }
            Console.WriteLine("Total: " + count);
        }
        public static void GetKCombsTest()
        {
            var toPrint = String.Concat<int>(Value);
            Console.WriteLine("GetKCombsTest [" + toPrint + "]");

            var unorderedPermutationsList = PermutationArray.GetKCombs(Value, Value.Length);
            var count = 0;
            foreach (var row in unorderedPermutationsList)
            {
                toPrint = String.Concat<int>(row);
                Console.WriteLine("[" + toPrint + "]");
                count++;
            }
            Console.WriteLine("Total: " + count);
        }
    }
}
