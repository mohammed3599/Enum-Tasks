using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Task
{
    internal class TrafficLights
    {
        public static void TrafficLightSequence(int durationRed, int durationYellow, int durationGreen, int iteration)
        {
            for (int i = 0; i < iteration; i++)
            {
                foreach (TrafficLight currentlight in Enum.GetValues(typeof(TrafficLight)))
                {
                    Console.WriteLine($"The Current light color now is: {currentlight}");
                    Thread.Sleep(durationGreen);
                }
            }
        }
    }
    enum TrafficLight
    {
        RED,
        YELLOW,
        GREEN
    }
}
