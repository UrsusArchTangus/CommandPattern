using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Lights
{
    interface Light
    {
        void On();
        void Off();
        void SetNewPlacement(string newPlacement);
    }
}
