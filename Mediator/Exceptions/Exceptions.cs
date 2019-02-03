using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Exceptions
{
    public class AlreadyRegisteredException : Exception { }
    public class NonRegisteredSenderException : Exception { }
    public class NonRegisteredReceiverException : Exception { }
}


