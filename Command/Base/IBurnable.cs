using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Command.Base
{
    public interface IBurnable
    {
        void Ignite();
        void Extinguish();
    }
}
