class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
       Console.WriteLine( s.LongestCommonPrefix(["flower", "flow", "flight"]));

    }
}


public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string result = "";
        for (int i = 0; i <= 200; i++)
        {
            bool flag = true;
            foreach (string str in strs)
            {
                if (i < str.Length && i < strs[0].Length)
                {
                    if (str[i] != strs[0][i])
                    {
                        flag = false;
                        break;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                result += strs[0][i];
            }
            else
            {
                break;
            }
        }
        return result;
    }
}