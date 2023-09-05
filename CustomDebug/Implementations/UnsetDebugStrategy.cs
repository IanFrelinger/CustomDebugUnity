using System;
using CustomDebug.Templates;

namespace CustomDebug.Implementations
{
    public class UnsetDebugStrategy : IDebugStrategy
    {
        public void HandleDebugMessage(string message)
        {
            throw new InvalidOperationException("Debug mode hasn't been set.");
        }
    }
}