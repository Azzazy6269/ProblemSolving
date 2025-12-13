class Program
{
    static void Main(string[] args)
    {

    }
}

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0 , count =0;
        foreach (var item in nums)
        {
            if(count == 0)
            {
                candidate=item;
                count++;
            }
            else
            {
                if(item == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return candidate;
    }
}