using System;
using System.Collections.Generic;
using System.Text;
using MichelsMichels.SoftwarePatterns.ChainOfResponsibility.Base;

namespace MichelsMichels.SoftwarePatterns.ChainOfResponsibility.Implementation
{
    public class Captain : Handler<string>
    {
        // Methods
        public override void HandleRequest(string message)
        {
            if (CanHandle(message))
            {
                Console.WriteLine("I, captain, received the message!");
            } else if(successor != null)
            {
                successor.HandleRequest(message);
            }
        }

        private bool CanHandle(string message)
        {
            return message.Contains("one", StringComparison.OrdinalIgnoreCase);
        }
    }
}
