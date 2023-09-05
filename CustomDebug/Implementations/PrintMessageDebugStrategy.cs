using System;
using CustomDebug.Templates;

namespace CustomDebug.Implementations
{
    public class PrintMessageDebugStrategy : IDebugStrategy
    {
        public void HandleDebugMessage(string message)
        {
            Console.WriteLine($"DEBUG: {message}");
        }
    }
}