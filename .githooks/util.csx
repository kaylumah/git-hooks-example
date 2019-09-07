public class Util
{
    public static string CommandLineArgument(IList<string> Args, int position)
    {
        if (Args.Count() >= position + 1)
        {
            return Args[position];
        }
        return string.Empty;
    }

}