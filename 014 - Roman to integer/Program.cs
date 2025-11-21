using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine( s.RomanToInt("MCMXCIV"));
    }
}

public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        char ch;

        for (int i = 0; i < s.Length; i++)
        {
            ch = s[i];

            if (ch == 'I')
            {
                if (i + 1 < s.Length && s[i + 1] == 'V')
                {
                    result += 4;
                    i++;
                }
                else if (i + 1 < s.Length && s[i + 1] == 'X')
                {
                    result += 9;
                    i++;
                }
                else
                {
                    result += 1;
                }
            }
            else if (ch == 'V')
            {
                result += 5;
            }
            else if (ch == 'X')
            {
                if (i + 1 < s.Length && s[i + 1] == 'L')
                {
                    result += 40;
                    i++;
                }
                else if (i + 1 < s.Length && s[i + 1] == 'C')
                {
                    result += 90;
                    i++;
                }
                else
                {
                    result += 10;
                }
            }
            else if (ch == 'L')
            {
                result += 50;
            }
            else if (ch == 'C')
            {
                if (i + 1 < s.Length && s[i + 1] == 'D')
                {
                    result += 400;
                    i++;
                }
                else if (i + 1 < s.Length && s[i + 1] == 'M')
                {
                    result += 900;
                    i++;
                }
                else
                {
                    result += 100;
                }
            }
            else if (ch == 'D')
            {
                result += 500;
            }
            else if (ch == 'M')
            {
                result += 1000;
            }
        }

        return result;
    }
}
