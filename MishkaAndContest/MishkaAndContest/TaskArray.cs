using System;
using System.Collections.Generic;
using System.Text;

namespace MishkaAndContest
{
    public class TaskArray
    {
        public static int[] FillTask(int taskNumbers, int[] eachDifficulty)
        {
            int[] eachTask = new int[taskNumbers];
            for (int i = 0; i < taskNumbers; i++)
            {
                eachTask[i] = eachDifficulty[i];
            }
            return eachTask;
        }
    }
}
