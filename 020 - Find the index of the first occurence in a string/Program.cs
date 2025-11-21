public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int index=-1;
        for(int i=0; i < haystack.Length - needle.Length+1; i++)
        {
            if (haystack[i] == needle[0])
            {
                int ii = i;
                int j = 0;
                for(j =0; j < needle.Length; j++)
                {
                    if (ii<haystack.Length && haystack[ii] == needle[j])
                    {
                        ii++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (j == needle.Length)
                {
                    index = i;
                    break;
                }
                    
            }
        }
        return index;
    }
}   

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.StrStr("leetcode", "tco"));
    }
}