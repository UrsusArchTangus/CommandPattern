using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Lights;

namespace CommandPattern.Commands
{
    class AllLightOn : Command
    {
        private Command[] _light;

        public AllLightOn(Command[] LightCommands)
        {
            _light = LightCommands;
        }

        public void Execute()
        {
            foreach (var item in _light)
            {
                item.Execute();
            }
        }
    }
}
