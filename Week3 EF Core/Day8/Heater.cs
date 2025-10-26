using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayEight
{
    public class Heater
    {
        public float Temp { get; set; }

        public void TemperatureChanged(float newTemp)
        {
            if (newTemp < Temp)
                Console.WriteLine($"[Heater] ON as Current Temp : {newTemp}");
            else
                Console.WriteLine($"[Heater] OFF as Current Temp: {newTemp}");
        }
    }
}
