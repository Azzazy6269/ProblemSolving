public class Solution
{
    public int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);
        int low = 0;
        int high = position[position.Length-1];
        int mid = 0;
        int validDistance=0;
        while (low <= high )
        {
             mid = (low + high) / 2;
            if(canPlace(position, m, mid))
            {
                validDistance = mid;
                low = mid+1;
            }
            else
            {
                high = mid-1;
            }
        }
        return validDistance;
    }
    bool canPlace(int[] position,int m ,int distance) 
    {
        int i = 0 ;
        int j = 0;
        while (m > 0 && j <= position.Length-1) 
        {
            m--;
            i = j;
            for (j = i+1; j < position.Length; j++)
            {
                if (position[j] - position[i] >= distance)
                    break;
            }

        }
        if(m==0)
            return true;
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] position = { 79, 74, 57, 22 };
        int m = 4;

        int result = solution.MaxDistance(position, m);

        Console.WriteLine("Max Distance = " + result);
        
    }
}
