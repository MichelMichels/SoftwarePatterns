using System;
using System.Collections.Generic;
using System.Text;
using SoftwarePatterns.Behavioral.ChainOfResponsibility.Base;

namespace SoftwarePatterns.Behavioral.ChainOfResponsibility.Implementation
{
    public class Major : Handler<string>
    {
        public override void HandleRequest(string message)
        {
            if(CanHandle(message))
            {
                Console.WriteLine("I, Major, received the message!");
            } else if(successor != null)
            {
                successor.HandleRequest(message);
            }
        }

        private bool CanHandle(string message)
        {
            return message.StartsWith("Major", StringComparison.OrdinalIgnoreCase);
        }
    }
}
