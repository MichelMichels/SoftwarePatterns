using Mediator.Interfaces;
using Mediator.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace Mediator.Implementation
{
    public class ChatRoom : IChatRoom
    {
        private Dictionary<string, IChatClient> registeredClients;

        public ChatRoom()
        {
            registeredClients = new Dictionary<string, IChatClient>();          
        }

        public IEnumerable<string> RegisteredUsers
        {
            get => registeredClients.Keys;
        }

        public void Register(IChatClient client)
        {
            if (IsRegistered(client.Name))
                throw new AlreadyRegisteredException();

            registeredClients.Add(client.Name, client);
            client.ChatRoom = this;
        }        
        public void Relay(string sender, string receiver, IMessage message)
        {
            if (IsNotRegistered(sender))
                throw new NonRegisteredSenderException();
            if (IsNotRegistered(receiver))
                throw new NonRegisteredReceiverException();

            registeredClients[receiver].Receive(sender, message);
        }

        private bool IsRegistered(string name)
        {
            return registeredClients.ContainsKey(name);
        }
        private bool IsNotRegistered(string name)
        {
            return !IsRegistered(name);
        }
    }
}
