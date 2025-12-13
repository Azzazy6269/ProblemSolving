class Program
{
    static void Main(string[] args)
    {

    }
}

public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        int candidate1 = 0, candidate2 = 0;
        int count1 = 0, count2 = 0;

        foreach (int num in nums)
        {
            if (num == candidate1)
                count1++;
            else if (num == candidate2)
                count2++;
            else if (count1 == 0)
            {
                candidate1 = num;
                count1 = 1;
            }
            else if (count2 == 0)
            {
                candidate2 = num;
                count2 = 1;
            }
            else
            {
                count1--;
                count2--;
            }
        }

        count1 = 0;
        count2 = 0;

        foreach (int num in nums)
        {
            if (num == candidate1) count1++;
            else if (num == candidate2) count2++;
        }

        List<int> result = new List<int>();
        int n = nums.Length;

        if (count1 > n / 3) result.Add(candidate1);
        if (count2 > n / 3) result.Add(candidate2);

        return result;
    }
}
    