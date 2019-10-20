using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Lights;

namespace CommandPattern.Commands
{
    class LightOn : Command
    {
        private Light _light;

        public LightOn(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}
