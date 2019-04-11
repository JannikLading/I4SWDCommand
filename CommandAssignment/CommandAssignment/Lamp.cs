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
        private bool _state;

        public Lamp(Polygon lamp)
        {
            _lamp = lamp; 
        }

        public bool GetState()
        {
            return _state;
        }

        public void TurnOn()
        {
            _state = true;
            _lamp.Opacity = 0.5;
            Trace.WriteLine("Lamp On");
        }

        public void TurnOff()
        {
            _state = false;
            _lamp.Opacity = 0;  
            Trace.WriteLine("Lamp Off");
        }
        public void Increase()
        {
            if (_state)
            {
                if (_lamp.Opacity < 1)
                {
                    _lamp.Opacity += 0.1;
                    Trace.WriteLine("Lamp up");
                }
            }
        }

        public void Decrease()
        {
            if (_state)
            {
                if (0 < _lamp.Opacity)
                {
                    _lamp.Opacity -= 0.1;
                    Trace.WriteLine("Lamp down");
                }
            }
        }
    }
}
