using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandAssignment.Commands;

namespace CommandAssignment
{
   public class Lamp : IDevice
    {
        public void TurnOn()
        {
            Trace.WriteLine("Lamp On");
        }

        public void TurnOff()
        {
            Trace.WriteLine("Lamp Off");
        }
        public void Increase()
        {
            Trace.WriteLine("Lamp up");
        }

        public void Decrease()
        {
            Trace.WriteLine("Lamp down");
        }
    }
}
