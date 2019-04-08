using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Iterator.Base.Interfaces
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
