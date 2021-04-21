using System;
using System.Collections.Generic;
using System.Text;

namespace WaterVolumeAfterRain
{
    class Volume
    {
        public int GetVolume(int[] waterWall)
        {

            int leftMax = 0; // наибольшее значение слева
            int rightMax = 0; // наибольшее значение справа
            int left = 0; // левый указатель
            int right = waterWall.Length - 1; //правый указатель
            int volume = 0;

            while (left < right)
            {
                if (waterWall[left] > leftMax)
                {
                    leftMax = waterWall[left]; // сдвиг левого указателя
                }
                if (waterWall[right] > rightMax)
                {
                    rightMax = waterWall[right]; // сдвиг правого указателя
                }
                if (leftMax >= rightMax)
                {
                    volume += rightMax - waterWall[right];
                    right--;
                }
                else
                {
                    volume += leftMax - waterWall[left];
                    left++;
                }

            }
            return volume;
        }
    }
}
