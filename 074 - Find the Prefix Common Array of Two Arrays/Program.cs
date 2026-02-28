class Program
{
    static void Main(string[] args)
    {

    }
}

public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        HashSet<int> ints = new HashSet<int>();
        int count = 0;
        int[] result = new int[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            if (ints.Contains(A[i]))
            {
                count++;
            }
            else
            {
                ints.Add(A[i]);
            }

            if (ints.Contains(B[i]))
            {
                count++;
            }
            else
            {
                ints.Add(B[i]);
            }

            result[i] = count;

        }
        return result;
    }
}