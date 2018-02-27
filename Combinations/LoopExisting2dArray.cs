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
            var currentCombinationIndex = -1;
            var currentCombination = new int[noOfLists];
            noOfCombinations = nest3(currentCombination, currentCombinationIndex, doWork, noOfCombinations);
            return noOfCombinations;
        }

        private int nest3(int[] currentCombination, int currentCombinationIndex, Action<int[]> doWork, int noOfCombinations)
        {
            currentCombinationIndex++;
            foreach (var item in _listOfLists[currentCombinationIndex])
            {
                currentCombination[currentCombinationIndex] = item;
                noOfCombinations = nest2(currentCombination, currentCombinationIndex, doWork, noOfCombinations);
            }

            return noOfCombinations;
        }

        private int nest2(int[] currentCombination, int currentCombinationIndex, Action<int[]> doWork, int noOfCombinations)
        {
            currentCombinationIndex++;
            foreach (var word2 in _listOfLists[currentCombinationIndex])
            {
                currentCombination[currentCombinationIndex] = word2;
                noOfCombinations = Nest(currentCombination, currentCombinationIndex, doWork, noOfCombinations);
            }

            return noOfCombinations;
        }

        private int Nest(int[] currentCombination, int currentCombinationIndex, Action<int[]> doWork, int noOfCombinations)
        {
            currentCombinationIndex++;
            foreach (var word3 in _listOfLists[currentCombinationIndex])
            {
                currentCombination[currentCombinationIndex] = word3;
                doWork(currentCombination);
                noOfCombinations++;
            }

            return noOfCombinations;
        }
    }
}
