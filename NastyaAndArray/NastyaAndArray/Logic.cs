using System;
using System.Collections.Generic;
using System.Text;

namespace NastyaAndArray
{
    public class Logic
    {
       public int Calculate(int size, int[] arr)
        {
            int res = 0; // количество секунд
            Array.Sort(arr); // сортируем наш массив
            if (arr[0] != 0) // если нулевой элемент не равен нулю, то прибавляем секунду
            {
                res++;
            }
            for (int i = 1; i < size; i++)
            {
                if (arr[i] != 0 && arr[i] != arr[i - 1]) // если первый элемент не равен нулю и не равен предыдущему, прибавляем секунду
                {
                    res++;
                }
            }
            return res;
        }
    }
}

