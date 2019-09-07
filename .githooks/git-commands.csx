#load "logger.csx"
#load "command-line.csx"
public class GitCommands
{
    public static void StashChanges()
    {
        CommandLine.Execute("git stash -q --keep-index");
    }
    public static void UnstashChanges()
    {
        CommandLine.Execute("git stash pop -q");
    }

    public static string CurrentBranch()
    {
        return CommandLine.Execute("git symbolic-ref --short HEAD");
    }

    public static string[] ChangedFiles()
    {
        string result = CommandLine.Execute("git diff --cached --name-only --diff-filter=ACM");
        string[] files = result.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        return files;
    }
}