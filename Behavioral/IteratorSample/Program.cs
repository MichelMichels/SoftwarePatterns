using SoftwarePatterns.Behavioral.Iterator.Implementation;
using System;
using System.Collections.Generic;

namespace SoftwarePatterns.Behavioral.Iterator;

class Program
{
    static void Main(string[] args)
    {
        var sticks = new[]
        {
            new Stick(3),
            new Stick(1),
            new Stick(9),
        };

        var bundle = new Bundle<Stick>(sticks);
        var iterator = bundle.CreateIterator();

        Console.WriteLine(iterator.Next());
        Console.WriteLine(iterator.Next());
        Console.WriteLine(iterator.Next());

        Console.ReadKey();
    }
}