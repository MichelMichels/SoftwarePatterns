using SoftwarePatterns.Behavioral.Command.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Command.Implementation;

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