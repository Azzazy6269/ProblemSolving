public class Solution
{
    public int[] RecoverOrder(int[] order, int[] friends)
    {
        HashSet<int> friendSet = new HashSet<int>(friends);
        int[] result = new int[friends.Length];
        int index = 0;
        foreach(int i in order)
        {
            if(friendSet.Contains(i))
                result[index++] = i;
        }
        return result;
    }
}

public class Program
{
    static void Main(string[] args)
    {

    }
}