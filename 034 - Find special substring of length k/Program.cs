class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.HasSpecialSubstring("asaacaaacc", 3));
        Console.WriteLine(s.HasSpecialSubstring("asaxacaaacxc",2));
    }
}

public class Solution
{
    public bool HasSpecialSubstring(string s, int k)
    {
        char current;
        int count;
        for (int i = 0; i < s.Length; i++) 
        {
            current = s[i];
            count = 1;
            while (i<s.Length-1 && current == s[i + 1])
            {
                i++;
                count++;
            }
            if (count == k) 
                return true;
        }
        return false;
    }
}