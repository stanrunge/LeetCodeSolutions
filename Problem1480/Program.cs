namespace Problem1480;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    private static int[] RunningSum(int[] nums)
    {
        var answer = new int[nums.Length];
        answer[0] = nums[0];
        
        for (var i = 1; i < nums.Length; i++)
        {
            answer[i] = answer[i - 1] + nums[i];
        }

        return answer;
    }
}