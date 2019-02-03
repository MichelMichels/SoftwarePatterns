using Iterator.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Implementation
{
    public class Bundle<T> : IAggregate<T>
    {
        private IEnumerable<T> enumerable;

        public Bundle()
        {
            enumerable = new List<T>();
        }
        public Bundle(IEnumerable<T> enumerable) 
        {
            this.enumerable = enumerable;
        }

        public IIterator<T> CreateIterator()
        {
            return new Iterator<T>(enumerable);
        }
    }
}
