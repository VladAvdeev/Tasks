using System;
using System.Collections.Generic;
using System.Text;

namespace MishkaAndContest
{
    public class ProblemArray
    {
        public  int[] FillTask(int numberOfProblem, int[] eachDifficulty)
        {
            int[] eachProblem = new int[numberOfProblem]; // массив с заданиями
            for (int i = 0; i < numberOfProblem; i++)
            {
                eachProblem[i] = eachDifficulty[i]; // заполняем массив задачами, у каждой из которых своя сложность
            }
            return eachProblem;
        }
    }
}
