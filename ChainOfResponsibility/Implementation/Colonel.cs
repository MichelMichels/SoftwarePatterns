using SoftwarePatterns.Behavioral.ChainOfResponsibility.Base;
using System;

namespace SoftwarePatterns.Behavioral.ChainOfResponsibility.Implementation;

public class Colonel : Handler<string>
{
    public override void HandleRequest(string param)
    {
        if (CanHandle(param))
        {
            Console.WriteLine("I, Colonel, received the message!");
        }
        else if (successor != null)
        {
            successor.HandleRequest(param);
        }
        else
        {
            Console.WriteLine("The message has reached the end of the chain! No one read the message.");
        }
    }

    private bool CanHandle(string message)
    {
        return message.StartsWith("Colonel");
    }
}