public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int slow = 0, fast = 0;
        for (fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != val)
                nums[slow++] = nums[fast];
        }
        return slow;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}