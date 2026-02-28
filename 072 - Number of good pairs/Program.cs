public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        Dictionary<int,int> count = new Dictionary<int,int>();
        int pairs = 0;
        foreach (var i in nums)
        {
            if (count.ContainsKey(i))
            {
                pairs += count[i];
                count[i]++;
            }
            else
            {
                count[i] = 1;
            }
        }
        return pairs;
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}