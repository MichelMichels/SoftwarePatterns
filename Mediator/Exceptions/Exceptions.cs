using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwarePatterns.Behavioral.Mediator.Exceptions
{
    public class AlreadyRegisteredException : Exception { }
    public class NonRegisteredSenderException : Exception { }
    public class NonRegisteredReceiverException : Exception { }
}


