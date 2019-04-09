using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAssignment.Commands
{
    public class IncreaseCommand : ICommand
    {
        private IDevice _device;

        public IncreaseCommand(IDevice dev)
        {
            _device = dev;
        }

        public void Execute()
        {
            _device.Increase();
        }

        public void Undo()
        {
            _device.Decrease();
        }
    }
}
