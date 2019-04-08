using System;
using System.Collections.Generic;
using System.Text;
using SoftwarePatterns.Behavioral.Command.Base;

namespace SoftwarePatterns.Behavioral.Command.Implementation
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
