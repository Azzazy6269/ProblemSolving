public class Solution
{
    public int Search(int[] nums, int target)
    {
        int min = 0;
        int max = nums.Length-1;
        int mid = 0;
        int index = -1;
        while (max >= min)
        {
             mid = (max + min) / 2;
            if (nums[mid] == target)
            {
                index = mid;
                break;
            }
                
            if(nums[mid] > target)
            {
                max = mid -1;
            }
            else
            {
                min = mid +1;
            }
        }
        return index;
    }
}

public class Program
{
    public static void main(string[] args)
    {

    }
}