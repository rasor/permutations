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
            var looper = new LoopExisting2dArray(_listOfLists);
            bool ok = looper.ForEachExecute(DoWork);
        }

        protected void DoWork(int[] combination) {
            Console.WriteLine("["+String.Join(", ", combination)+"]");
        }
    }
}
