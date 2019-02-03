using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Implementation
{
    public class Stick
    {      
        public Stick()
        {
            Length = 1;
        }
        public Stick(int length)
        {
            Length = length;
        }

        public int Length { get; set; }

        public override string ToString()
        {
            return $"I'm a stick of length {Length}!";
        }
    }
}
