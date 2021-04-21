using System;

namespace WaterVolumeAfterRain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 5, 1, 2, 3, 4, 7, 7, 6 };
            Console.WriteLine(GetVolume(array));
        }
        public static int GetVolume(int[] nums)
        {
            int leftMax = 0;
            int rightMax = 0;
            int left = 0;
            int right = nums.Length - 1;
            int volume = 0;

            while( left < right)
            {
                if(nums[left] > leftMax)
                {
                    leftMax = nums[left];
                }
                if(nums[right] > rightMax)
                {
                    rightMax = nums[right];
                }
                if(leftMax >= rightMax)
                {
                    volume += rightMax - nums[right];
                    right--;
                }
                else
                {
                    volume += leftMax - nums[left];
                    left++;
                }

            }
            return volume;
        }
    }
}
