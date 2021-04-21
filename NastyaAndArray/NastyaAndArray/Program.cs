using System;
using System.Linq;

namespace NastyaAndArray
{
    public class Program
    {
        static void Main(string[] args)
        {

            int size = Convert.ToInt32(Console.ReadLine()); // размер массива
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // ввод массива с клавиатура через пробел
            Logic logic = new Logic();
            Console.WriteLine(logic.Calculate(size, array));
        }
    }
}
