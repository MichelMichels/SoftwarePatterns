﻿using Command.Base;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Receiver
            var fire = new Fire();

            // Commands
            var igniteCommand = new IgniteCommmand(fire);
            var extinguishCommand = new ExtinguishCommand(fire);

            // Invoker
            var arsonist = new Arsonist(igniteCommand, extinguishCommand);
            arsonist.IgniteFire();
            arsonist.ExtinguishFire();

            Console.ReadKey();
        }
    }
}
