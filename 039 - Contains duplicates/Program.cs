class Program
{
    static void Main(string[] args)
    {

    }
}


public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach(int num in nums)
        {
            if (!set.Add(num))
                return true;
        }
        return false;
    }
}

/*public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                return true;
        }
        return false;
    }
}*/