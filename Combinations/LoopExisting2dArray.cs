using System;

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
            //Loop through combinations the itemlists in the _listOfLists
            var noOfLists = _listOfLists.Length;
            var noOfCombinations = 0;
            var currentCombinationIndex = -1;
            var currentCombination = new int[noOfLists];
            noOfCombinations = recurseCombinations(currentCombination, currentCombinationIndex, doWork, noOfCombinations);
            return noOfCombinations;
        }

        private int recurseCombinations(int[] currentCombination, int currentCombinationIndex, Action<int[]> doWork, int noOfCombinations)
        {
            currentCombinationIndex++;
            foreach (var item in _listOfLists[currentCombinationIndex])
            {
                currentCombination[currentCombinationIndex] = item;
                if (currentCombinationIndex < currentCombination.Length-1)
                {
                    noOfCombinations = recurseCombinations(currentCombination, currentCombinationIndex, doWork, noOfCombinations);
                }
                else
                {
                    doWork(currentCombination);
                    noOfCombinations++;
                }
            }
            return noOfCombinations;
        }
    }
}
