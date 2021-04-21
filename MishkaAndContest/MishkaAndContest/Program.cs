using System;
using System.Linq;

namespace MishkaAndContest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество задач: ");
            int countTask = Convert.ToInt32(Console.ReadLine()); // количество задач
            
            Console.WriteLine("Введите умение Мишки решать задачи: ");
            int skill = Convert.ToInt32(Console.ReadLine()); // умение решать задачи
            
            Console.WriteLine("Заполните сложность каждой задачи через пробел");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // сложность каждой задачи
            
            ProblemArray taskDificluty = new ProblemArray();
            int[] fullTask = taskDificluty.FillTask(countTask, arr); // заполняем наш массив задачами со сложностями 

            Problem countCompletedProblem = new Problem();
            Console.WriteLine(countCompletedProblem.CompletedCountProblem(fullTask, skill)); // высчитываем количество выполненных задач и выводим на консоль
        }

    }
}
