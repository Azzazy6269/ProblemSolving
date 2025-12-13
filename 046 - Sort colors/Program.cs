public class Solution
{
    public void SortColors(int[] nums)
    {
        //selection sort
        int minIndex;
        int n = nums.Length;
        for (int i = 0; i < n - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (nums[minIndex] > nums[j])
                {
                    minIndex = j;
                }

            }
            int temp = nums[i];
            nums[i] = nums[minIndex];
            nums[minIndex] = temp;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}