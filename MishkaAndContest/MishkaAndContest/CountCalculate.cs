using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MishkaAndContest
{
    class CountCalculate
    {
        public int CompletedCount(int[] array, int skill)
        {
            int leftSide = array.TakeWhile(x => x <= skill).Count(); // проходим по массиву слева направо
            if(leftSide != array.Count()) // если при проходе слева направо оказалась задача, которую Мишка не может решить
                                          // начинаем проход по массиву справа налево
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
