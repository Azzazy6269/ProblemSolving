public class Solution
{
    public bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length-1;
        s = s.ToLower();
        char ii, jj;
        while(i<j)
        {
            while (i < j && !isAlphaNumeric(s[i]))
            {
                i++;
            }
            while (i < j && !isAlphaNumeric(s[j]))
            {
                j--;
            }
            if (s[i] == s[j])
            {
                i++;
                j--;
            }
            else
            {
                return false;
            }

        }
        return true;
    }
    bool isAlphaNumeric(char ch)
    {
        if((ch>='a'&&ch<='z')||(ch>='0'&&ch<='9'))
            return true;
        return false;
    }
}

class Program
{
    static void Main(string [] args)
    {
        Solution s = new Solution();
        Console.WriteLine("excpected true\nresult "+s.IsPalindrome("   rec d:&*Cer")+"\n============");
        Console.WriteLine("expected true\nresult " + s.IsPalindrome("A man, a plan, a canal: Panama") + "\n============");
        Console.WriteLine("expected true\nresult " + s.IsPalindrome("No lemon, no melon") + "\n============");
        Console.WriteLine("expected false\nresult " + s.IsPalindrome("hello") + "\n============");
        Console.WriteLine("expected true\nresult " + s.IsPalindrome("Was it a car or a cat I saw?") + "\n============");
        Console.WriteLine("expected true\nresult " + s.IsPalindrome("!@#$%^&*()") + "\n============"); // no letters → empty → palindrome
        Console.WriteLine("expected false\nresult " + s.IsPalindrome("abcddcbaZ") + "\n============");
        Console.WriteLine("expected true\nresult " + s.IsPalindrome("RaceCar") + "\n============");
        Console.WriteLine("expected false\nresult " + s.IsPalindrome("not a palindrome") + "\n============");
        Console.WriteLine("expected true\nresult " + s.IsPalindrome("   r e c e r   ") + "\n============");
        Console.WriteLine("expected true\nresult " + s.IsPalindrome("MadaM") + "\n============");
        Console.WriteLine("expected false\nresult " + s.IsPalindrome("0P") + "\n============");
    }
}