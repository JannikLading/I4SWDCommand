using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAssignment.Commands
{
   public class ToggleCommand: ICommand
   {
        private IDevice _device; 

        public ToggleCommand(IDevice dev)
        {
            _device = dev;
        }
        
        public void Execute()
        {
            if (!_device.GetState())
            {
                _device.TurnOn();
            }
            else
            {
                _device.TurnOff();
            }
        }

        public void Undo()
        {
            if (_device.GetState())
            {
                _device.TurnOff();
            }
            else
            {
                _device.TurnOn();
            }
        }
    }
}
