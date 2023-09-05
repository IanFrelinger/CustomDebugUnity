using CustomDebug.Templates;

namespace CustomDebug.Behaviors
{
    public static class DebugSystem
    {
        public static IDebugStrategy debugStrategy { get; set; }
        public static void DebugMessage(string message)
        {
            debugStrategy.HandleDebugMessage(message);
        }
    }
}