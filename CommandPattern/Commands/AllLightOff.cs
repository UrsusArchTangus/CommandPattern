using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Lights;

namespace CommandPattern.Commands
{
    class AllLightOff : Command
    {

        private Command[] _light;

        public AllLightOff(Command[] light)
        {
            _light = light;
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
