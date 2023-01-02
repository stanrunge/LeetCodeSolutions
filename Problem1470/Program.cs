namespace Problem1470;

public class Program
{
    public static void Main(string[] args)
    {
        Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);
    }

    private static int[] Shuffle(int[] nums, int n)
    {
        var answer = new int[nums.Length];
        
        for (var i = 0; i < nums.Length; i++)
        {
            if (i % 2 == 0)
            {
                answer[i] = nums[i / 2];
            }
            else
            {
                answer[i] = nums[((i - 1) / 2) + nums.Length / 2];
            }
        }

        return answer;
    }
}