using System;

namespace WaterVolumeAfterRain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] waterWall = new int[] { 2, 5, 1, 2, 3, 4, 7, 7, 6 };
            Volume volume = new Volume();
            Console.WriteLine(volume.GetVolume(waterWall));
        }
        
    }
}

