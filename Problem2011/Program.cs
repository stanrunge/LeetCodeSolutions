namespace Problem2011;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    private static int FinalValueAfterOperaions(string[] operations)
    {
        var increments = operations.ToList().FindAll(x => x == "++X" || x == "X++").Count();
        var decrements = operations.ToList().FindAll(x => x == "--X" || x == "X--").Count();

        return increments - decrements;
    }
}