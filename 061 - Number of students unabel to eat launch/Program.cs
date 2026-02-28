public class Solution
{
    public int  CountStudents(int[] students, int[] sandwiches)
    {
        int count0 = 0, count1 = 0;
        foreach (var item in students)
        {
            if(item ==0)
                count0++;
            if(item ==1)
                count1++;
        }
        foreach (var item in sandwiches)
        {
            if (item == 0 && count0 > 0)
            {
                count0--;
            }   
            else if (item == 1 && count1 > 0)
            {
                count1--;
            }
            else
            {
                break;
            }
                
        }
        return count0+count1;
    }
}
class Program
{
    static void Main(string[] args)
    {

    }
}