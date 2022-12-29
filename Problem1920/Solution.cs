namespace Problem1920;

public abstract class Solution {
    public static void Main(string[] args)
    {
        var array = new int[6];
        BuildArray(array);
    }

    private static int[] BuildArray(int[] nums) {
        var ans = new int[nums.Length];

        for(var i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[nums[i]];
        }

        return ans;
    }
}