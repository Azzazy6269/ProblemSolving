public class Solution
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        HashSet<int> ints = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (var i in nums)
        {
            if(ints.Contains(i))
                result.Add(i);
            ints.Add(i);
        }
        return result.ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}