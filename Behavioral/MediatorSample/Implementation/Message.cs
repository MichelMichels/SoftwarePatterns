using SoftwarePatterns.Behavioral.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Mediator.Implementation;

public class Message : IMessage
{
    private Message(string text)
    {
        Text = text;
        SendDate = DateTime.Now;
    }

    public static Message Create(string text) => new Message(text);

    public string Text { get; private set; }
    public DateTime SendDate { get; private set; }
}