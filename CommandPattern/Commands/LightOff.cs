using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Lights;

namespace CommandPattern.Commands
{
    class LightOff : Command
    {
        private Light _light;

        public LightOff(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}
