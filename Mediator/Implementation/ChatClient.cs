using System;
using System.Collections.Generic;
using System.Text;
using Mediator.Interfaces;

namespace Mediator.Implementation
{
    public class ChatClient : IChatClient
    {
        public ChatClient(string name)
        {
            Name = name;
        }

        // Properties
        public string Name { get; }
        public IChatRoom ChatRoom { get; set; }

        // Methods
        public void Send(string receiver, IMessage message)
        {
            ChatRoom.Relay(Name, receiver, message);
        }
        public void Receive(string sender, IMessage message)
        {
            Console.WriteLine($"I, {Name}, received a message from {sender} at {message.SendDate.ToShortDateString()}: '{message.Text}'");
        }
    }
}
