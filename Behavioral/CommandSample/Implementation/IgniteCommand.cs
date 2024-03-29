﻿using SoftwarePatterns.Behavioral.Command.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Command.Implementation;

public class IgniteCommmand : ICommand
{
    private IBurnable burnable;

    public IgniteCommmand(IBurnable burnable)
    {
        this.burnable = burnable;
    }

    public void Execute()
    {
        burnable.Ignite();
    }
}