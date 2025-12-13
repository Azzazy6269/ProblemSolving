class Program
{
    static void Main(string[] args)
    {

    }
}

public class Solution
{
    public int MaximumGap(int[] nums)
    {
        if (nums.Length < 2)
            return 0;
        Array.Sort(nums);
        int maxGap = 0;
        int tempGap = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            tempGap = nums[i] - nums[i - 1];
            if(tempGap > maxGap)
                maxGap = tempGap;
        }
        return maxGap;
    }
}