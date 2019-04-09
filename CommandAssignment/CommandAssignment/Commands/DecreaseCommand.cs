using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAssignment.Commands
{
    public class DecreaseCommand : ICommand
    {
        private IDevice _device;

        public DecreaseCommand(IDevice dev)
        {
            _device = dev;
        }

        public void Execute()
        {
           _device.Decrease();
        }

        public void Undo()
        {
            _device.Increase();
        }
    }
}
