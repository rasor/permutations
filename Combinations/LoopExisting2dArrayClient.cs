using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Combinations
{
    public class LoopExisting2dArrayClient
    {
        private static int[][] _listOfLists = new int[][] {
            new int[] { 1, 2, 3, 4 },
            new int[] { 10, 20, 30, 40, 50 },
            new int[] { 100, 200, 300 }
        };

        public void LoopArray() {
            var ExpectedCombinations = _listOfLists[0].Length * _listOfLists[1].Length * _listOfLists[2].Length;
            Console.WriteLine("ExpectedCombinations: " + ExpectedCombinations);

            var looper = new LoopExisting2dArray(_listOfLists);
            var noOfCombinations = looper.ForEachExecute(DoWork);
            Console.WriteLine("Combinations: "+ noOfCombinations);
        }

        protected void DoWork(int[] combination) {
            Console.WriteLine("["+String.Join(", ", combination)+"]");
        }
    }
}
