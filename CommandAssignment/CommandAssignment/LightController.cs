using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandAssignment
{
    class LightController
    {
        private ICommand[] _commands;

        public LightController(int commands)
        {
            _commands= new ICommand[commands];
        }
        
        public void SetCommand(int index,ICommand command)
        {
            _commands[index] = command;
        }

        public void ExecuteCommand(int index)
        {
            _commands[index].Execute();
        }
    }
    

    
}
