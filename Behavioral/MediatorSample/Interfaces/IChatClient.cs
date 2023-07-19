using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Mediator.Interfaces;

public interface IChatClient
{
    // Properties
    string Name { get; }
    IChatRoom ChatRoom { get; set; }

    // Methods
    void Send(string receiver, IMessage message);
    void Receive(string sender, IMessage message);
}