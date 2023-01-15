namespace Problem1528;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(new Solution().RestoreString("codeleet", new []{4,5,6,7,0,2,1,3}));
    }
}

public class Solution {
    public string RestoreString(string s, int[] indices)
    {
        var shuffledString = "";

        for (var i = 0; i < s.Length; i++)
        {
            var index = Array.FindIndex(indices, integer => integer == i);

            shuffledString += s[index];
        }

        return shuffledString;
    }
}