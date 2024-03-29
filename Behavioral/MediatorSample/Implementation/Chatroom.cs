﻿using SoftwarePatterns.Behavioral.Mediator.Exceptions;
using SoftwarePatterns.Behavioral.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SoftwarePatterns.Behavioral.Mediator.Implementation;

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