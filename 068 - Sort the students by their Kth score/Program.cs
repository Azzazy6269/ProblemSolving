public class Solution
{
    public int[][] SortTheStudents(int[][] score, int k)
    {
        Array.Sort(score, (a, b) => b[k].CompareTo(a[k]));
        return score;
    }
}
/*public class Solution
{
    public int[][] SortTheStudents(int[][] score, int k)
    {
        List<int> sorted = new List<int>();
        foreach (int[] i in score) 
        {
            sorted.Add(i[k]);
        }
        sorted.Sort();
        sorted.Reverse();

        int[][]matrix= new int[score.Length][];
        int z = 0;
        foreach (int i in sorted)
        {
            foreach (int[] j in score)
            {
                if (j[k] == i)
                {
                    matrix[z++]=j;
                    break;
                }
                
            }
        }
        return matrix;
    }
}
*/

class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = new int[3][];
        matrix = [[10, 6, 9, 1], [7, 5, 11, 2], [4, 8, 3, 15]];
        Solution solution = new Solution();
        matrix = solution.SortTheStudents(matrix,2);
        for (int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[i].Length;j++)
            {
                Console.Write(matrix[i][j]+" ");
            }
            Console.WriteLine();
        }
    }
}