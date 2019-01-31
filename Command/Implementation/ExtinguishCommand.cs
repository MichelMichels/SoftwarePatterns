﻿using System;
using System.Collections.Generic;
using System.Text;
using Command.Base;

namespace Command.Implementation
{
    public class ExtinguishCommand : ICommand
    {
        private IBurnable burnable;

        public ExtinguishCommand(IBurnable burnable)
        {
            this.burnable = burnable;
        }

        public void Execute()
        {
            burnable.Extinguish();
        }
    }
}