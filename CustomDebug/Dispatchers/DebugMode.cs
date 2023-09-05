namespace CustomDebug.Dispatchers
{
    public enum DebugMode
    {
        Unset,      // Represents the default state (mode hasn't been set).
        ThrowError, // Mode to throw exceptions.
        PrintMessage // Mode to print debug messages.
    }
}