class Program
{
    static void Main(string[] args)
    {

    }
}


public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        IList<string> res = new List<string>();
        int i = 1;
        int j = 0;
        while ( j < target.Length)
        {
            if(i == target[j])
            {
                res.Add("Push");
                i++;
                j++;
            }
            else
            {
                res.Add("Push");
                res.Add("Pop");
                i++;
            }
               
        }
        return res;
    }
}