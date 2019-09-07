#load "logger.csx"
#load "command-line.csx"
public class DotnetCommands
{
    public static int FormatCode() => ExecuteCommand("dotnet format");
    public static int BuildCode() => ExecuteCommand("dotnet build");

    public static int TestCode() => ExecuteCommand("dotnet test");

    private static int ExecuteCommand(string command)
    {
        string response = CommandLine.Execute(command);
        Int32.TryParse(response, out int exitCode);
        return exitCode;
    }

}