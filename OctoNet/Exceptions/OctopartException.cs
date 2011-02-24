using System;

namespace OctoNet.Exceptions
{
    public class OctopartException : Exception
    {
        public OctopartException(string message)
            : base(message)
        {
            //Wrapper class for OctoNet Exceptions
        }

    }
}
