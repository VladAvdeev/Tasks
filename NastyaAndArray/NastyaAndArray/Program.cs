using System;
using System.Linq;

namespace NastyaAndArray
{
    public class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int res = 0;
            Array.Sort(array);
            if(array[0] != 0)
            {
                res++;
            }
            for (int i = 1; i < n; i++)
            {
               if(array[i] != 0 && array[i] != array[i - 1])
                {
                    res++;
                }

            }
            Console.WriteLine(res);

        }
    }
}
