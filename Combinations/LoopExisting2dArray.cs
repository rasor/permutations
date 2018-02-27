using System;
using System.Collections.Generic;
using System.Text;

namespace Combinations
{
    class LoopExisting2dArray
    {
        private int[][] _listOfLists;

        public LoopExisting2dArray(int[][] listOfLists)
        {
            _listOfLists = listOfLists;
        }

        internal int ForEachExecute(Action<int[]> doWork)
        {
            //Loop through combinations the wordlists in the _listOfLists
            var noOfLists = _listOfLists.Length;
            var noOfCombinations = 0;
            foreach (var word1 in _listOfLists[0])
            {
                foreach (var word2 in _listOfLists[1])
                {
                    foreach (var word3 in _listOfLists[2])
                    {
                        var combination = new int[] { word1, word2, word3 };
                        doWork(combination);
                        noOfCombinations++;
                    }
                }
            }
            return noOfCombinations;
        }
    }
}
