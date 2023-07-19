using SoftwarePatterns.Behavioral.Command.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Command.Implementation;

// Receiver
public class Fire : IBurnable
{
    public void Ignite()
    {
        Console.WriteLine("The fire burns!");
    }

    public void Extinguish()
    {
        Console.WriteLine("The fire is out!");
    }
}