using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Mediator.Interfaces;

public interface IMessage
{
    string Text { get; }
    DateTime SendDate { get; }
}