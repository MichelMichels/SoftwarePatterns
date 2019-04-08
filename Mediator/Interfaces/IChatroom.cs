using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Mediator.Interfaces
{
    // Mediator
    public interface IChatRoom
    {
        // Properties
        IEnumerable<string> RegisteredUsers { get; }

        // Methods
        void Register(IChatClient chatClient);
        void Relay(string sender, string receiver, IMessage message);
    }
}
