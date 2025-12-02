using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] arr = s.PlusOne(new int[] { 9, 9, 9, 9 });
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int i = digits.Length - 1;
        if (digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        else
        {
            while (i - 1 >= 0 && digits[i] == 9)
            {
                digits[i--] = 0;
            }
            if (i - 1 >= 0)
            {
                digits[i] += 1;
            }
            else if (i == 0 && digits[i] < 9)
            {
                digits[0] += 1;
            }
            else if (i == 0 && digits[i] == 9)
            {
                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                for (int x = 1; x < newDigits.Length; x++)
                    newDigits[x] = 0;
                digits = newDigits;
            }
        }
        return digits;
    }
}