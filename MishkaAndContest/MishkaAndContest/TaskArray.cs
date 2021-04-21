using System;
using System.Collections.Generic;
using System.Text;

namespace MishkaAndContest
{
    public class TaskArray
    {
        public  int[] FillTask(int taskNumbers, int[] eachDifficulty)
        {
            int[] eachTask = new int[taskNumbers]; // массив с заданиями
            for (int i = 0; i < taskNumbers; i++)
            {
                eachTask[i] = eachDifficulty[i]; // заполняем массив задачами, у каждой из которых своя сложность
            }
            return eachTask;
        }
    }
}
