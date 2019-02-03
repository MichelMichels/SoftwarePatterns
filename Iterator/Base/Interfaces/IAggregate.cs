using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Base.Interfaces
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
