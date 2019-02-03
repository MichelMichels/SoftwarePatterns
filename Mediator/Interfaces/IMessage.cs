using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Interfaces
{
    public interface IMessage
    {
        string Text { get; }
        DateTime SendDate { get; }
    }
}
