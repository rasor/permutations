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

        internal bool ForEachExecute(Action<int[]> doWork)
        {
            doWork(_listOfLists[0]);
            return true;
        }
    }
}
