namespace Problem1108;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    private static string DefangIPaddr(string address)
    {
        return address.Replace(".", "[.]");
    }
}