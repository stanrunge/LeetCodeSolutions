namespace Problem1929;

public abstract class Program
{
    public static void Main(string[] args)
    {
        
    }
    
    public static int[] GetConcatenation(int[] nums)
    {
        var ans = new int[nums.Length * 2];

        for (var i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
        }

        for (var i = 0; i < nums.Length; i++)
        {
            ans[i + nums.Length] = nums[i];
        }

        return ans;
    }
}