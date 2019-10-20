using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Lights
{
    class Light2 : Light
    {
        public string _lightPlacement;

        public Light2(string lightPlacement)
        {
            _lightPlacement = lightPlacement;
        }
        public void On()
        {
            Console.WriteLine($"{_lightPlacement} is ON");
        }

        public void Off()
        {
            Console.WriteLine($"{_lightPlacement} is OFF");
        }

        public void SetNewPlacement(string newPlacement)
        {
            _lightPlacement = newPlacement;
        }
    }
}
