using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MishkaAndContest
{
    class CountCalculate
    {
        public static int CompletedCount(int[] array, int skill)
        {
            int leftSide = array.TakeWhile(x => x <= skill).Count();
            if(leftSide != array.Count())
            {
                Array.Reverse(array);
                int rightSide = array.TakeWhile(x => x <= skill).Count();
                return leftSide + rightSide;
            }
            else
            {
                return leftSide;
            }
        }
    }
}
