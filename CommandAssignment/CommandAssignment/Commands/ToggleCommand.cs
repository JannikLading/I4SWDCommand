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
        private bool _state; 

        public ToggleCommand(IDevice dev)
        {
            _device = dev;
            _state = false; 
        }
        
        public void Execute()
        {
            if (!_state)
            {
                _device.TurnOn();
                _state = true;
            }
            else
            {
                _device.TurnOff();
                _state = false;
            }
        }

        public void Undo()
        {
            if (_state)
            {
                _device.TurnOff();
                _state = false;
            }
            else
            {
                _device.TurnOn();
                _state = true;
            }
        }
    }
}
