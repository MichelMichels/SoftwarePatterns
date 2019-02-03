using Iterator.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Implementation
{
    public class Iterator<T> : IIterator<T>
    {
        private int index = -1;
        private IEnumerable<T> enumerable;

        public Iterator(IEnumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        public T Next()
        {
            index++;
            return enumerable.ElementAt(index);
        }
    }
}
