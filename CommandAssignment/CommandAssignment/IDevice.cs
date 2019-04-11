using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAssignment
{
    public interface IDevice
    {
        bool GetState();
        void TurnOn();
        void TurnOff();
        void Increase();
        void Decrease();
    }
}
