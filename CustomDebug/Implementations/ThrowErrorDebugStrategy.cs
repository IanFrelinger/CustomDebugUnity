using System;
using CustomDebug.Templates;

namespace CustomDebug.Implementations
{
    public class ThrowErrorDebugStrategy : IDebugStrategy
    {
        public void HandleDebugMessage(string message)
        {
            throw new Exception(message);
        }
    }
}