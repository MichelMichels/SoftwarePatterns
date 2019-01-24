using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Base
{
    public interface IBurnable
    {
        void Ignite();
        void Extinguish();
    }
}
