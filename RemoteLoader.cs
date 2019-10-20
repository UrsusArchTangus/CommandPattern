using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;
using CommandPattern.Lights;

namespace CommandPattern
{
    class RemoteLoader
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl(3);

            // Creating objects to control
            Light garageLight = new Light1("Garage Light");
            Light livingRoomLight = new Light2("Living Room Light");
            // Creating commands for objects to control
            LightOn garageLightOnCommand = new LightOn(garageLight);
            LightOff garageLightOffCommand = new LightOff(garageLight);
            LightOn livingRoomLightOnCommand = new LightOn(livingRoomLight);
            LightOff livingRoomLightOffCommand = new LightOff(livingRoomLight);
            // Creating Collection for AllLightOff and AllLightOff commands.
            var LightsOn = new Command[] {garageLightOnCommand, livingRoomLightOnCommand};
            var LightsOff = new Command[] {garageLightOffCommand, livingRoomLightOffCommand };

        // Creating Macro commands
            AllLightOn houseLightsOnCommand = new AllLightOn(LightsOn);
            AllLightOff houseLightsOffCommand = new AllLightOff(LightsOff);
            

            // Loading commands into the remoteControl
            remoteControl.SetCommand(0, garageLightOnCommand, garageLightOffCommand);
            remoteControl.SetCommand(1, livingRoomLightOnCommand, livingRoomLightOffCommand);
            remoteControl.SetCommand(2, houseLightsOnCommand, houseLightsOffCommand);
            // Simulating button clicks
            remoteControl.OnButtonPushed(0);
            remoteControl.OffButtonPushed(0);
            remoteControl.OnButtonPushed(1);
            remoteControl.OffButtonPushed(1);
            remoteControl.OnButtonPushed(2);
            remoteControl.OffButtonPushed(2);
        }
    }
}
