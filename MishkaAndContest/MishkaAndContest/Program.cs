using System;
using System.Linq;

namespace MishkaAndContest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество задач: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите умение Мишки решать задачи: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Заполните сложность каждой задачи через пробел");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] arrayTask = TaskArray.FillTask(n, arr);
            Console.WriteLine(CountCalculate.CompletedCount(arrayTask, k));
        }

    }
}
