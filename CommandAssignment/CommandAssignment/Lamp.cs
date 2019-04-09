using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using CommandAssignment.Commands;

namespace CommandAssignment
{
   public class Lamp : IDevice
   {
        private Polygon _lamp; 

        public Lamp(Polygon lamp)
        {
            _lamp = lamp; 
        }

        public void TurnOn()
        {
            _lamp.Opacity = 0.5;
            Trace.WriteLine("Lamp On");
        }

        public void TurnOff()
        {
            _lamp.Opacity = 0;  
            Trace.WriteLine("Lamp Off");
        }
        public void Increase()
        {
            _lamp.Opacity += 0.1; 
            Trace.WriteLine("Lamp up");
        }

        public void Decrease()
        {
            _lamp.Opacity -= 0.1;
            Trace.WriteLine("Lamp down");
        }
    }
}
