using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAssignment.Commands
{
   public class TurnOnCommand: ICommand
   {
       private IDevice device; 

        public TurnOnCommand(IDevice dev)
        {
            device = dev;
        }
        
        public void Execute()
        {
            device.TurnOn();
        }

        public void Undo()
        {
            device.TurnOff();
        }
    }
}
