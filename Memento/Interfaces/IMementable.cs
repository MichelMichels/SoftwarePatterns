using System;
using System.Collections.Generic;
using System.Text;
using SoftwarePatterns.Behavioral.Memento.Implementation;

namespace SoftwarePatterns.Behavioral.Memento.Interfaces
{
    public interface IMementable
    {
        void SetMemento(Memento memento);
    }
}
