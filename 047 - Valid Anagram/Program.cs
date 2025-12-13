class Program
{
    static void Main(string[] args)
    {

    }
}

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;

        int[] count = new int[26];

        foreach (char ch in s)
        {
            count[ch - 'a']++;
        }

        foreach (char ch in t)
        {
            count[ch - 'a']--;
        }
        foreach(int i in count)
        {
            if (i !=0)
                return false;
        }
        return true;
    }
}