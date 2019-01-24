using System;
using System.Collections.Generic;
using System.Text;
using Command.Base;

namespace Command.Implementation
{
    // Invoker
    public class Arsonist
    {
        private ICommand igniteFireCommand, putOutFireCommand;
        
        public Arsonist(ICommand igniteFireCommand, ICommand putOutFireCommand)
        {
            this.igniteFireCommand = igniteFireCommand;
            this.putOutFireCommand = putOutFireCommand;
        }

        public void IgniteFire()
        {
            igniteFireCommand.Execute();
        }
        public void ExtinguishFire()
        {
            putOutFireCommand.Execute();
        }

    }
}
