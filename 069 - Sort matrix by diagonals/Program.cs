public class Solution
{
    public int[][] SortMatrix(int[][] grid)
    {
        for(int k = 0; k < grid.Length; k++) 
        {
            int i = k, j = 0;
            List<int> ints = new List<int>();
            while (i < grid.Length && j < grid.Length)
            {
                ints.Add(grid[i++][j++]);
            }
            ints.Sort();
            ints.Reverse();
            i = k;
            j = 0;
            int index = 0;
            while (i < grid.Length && j < grid.Length)
            {
                grid[i++][j++] = ints[index++];
            }
        }
        for (int k = 1; k < grid.Length; k++)
        {
            int i = 0, j = k;
            int index = 0;
            List<int> ints = new List<int>();
            while (i < grid.Length && j < grid.Length)
            {
                ints.Add(grid[i++][j++]);
           }
            ints.Sort();
            i = 0;
            j = k;
            index = 0;
            while (i < grid.Length && j < grid.Length)
            {
                grid[i++][j++] = ints[index++];
            }
        }

        return grid;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        int[][] matrix = [[-3, 0], [-5, 4]];
        s.SortMatrix(matrix);
    }
}