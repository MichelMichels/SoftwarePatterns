using SoftwarePatterns.Behavioral.ChainOfResponsibility.Implementation;
using System;
using Approver = SoftwarePatterns.Behavioral.ChainOfResponsibility.Base.Handler<string>;

namespace SoftwarePatterns.Behavioral.ChainOfResponsibility;

class Program
{
    static void Main(string[] args)
    {
        Approver captain = new Captain();
        Approver major = new Major();
        Approver colonel = new Colonel();

        captain
            .SetSuccessor(major)
            .SetSuccessor(colonel);

        captain.HandleRequest("Colonel! I need you <3");
        captain.HandleRequest("Major: How are you?");
        captain.HandleRequest("General: Is the general in there?");

        Console.ReadKey();
    }
}