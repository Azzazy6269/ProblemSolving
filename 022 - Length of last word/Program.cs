using System;
class Program
{
    static void Main()
    {
        Solution s = new Solution();
        Console.WriteLine(s.LengthOfLastWord("   fly me   to   the moon"));
    }
}

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int count = 0, i = s.Length - 1;
        while (s[i] == ' ')
        {
            if (i - 1 >= 0)
            {
                i--;
            }
            else
            {
                return 0;
            }

        }
        while (s[i] != ' ')
        {
            count++;
            if (i - 1 >= 0)
            {
                i--;
            }
            else
            {
                return count;
            }

        }
        return count;

    }
}