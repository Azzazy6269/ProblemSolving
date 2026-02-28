using System.ComponentModel;

class Program
{
    static void Main(string[] args) { }
}

public class Solution
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        int totalMoves = 0;
        Array.Sort(seats);
        Array.Sort(students);
        for (int i = 0; i < seats.Length; i++) 
        {
            totalMoves += Math.Abs(seats[i] - students[i]);
        }
        return totalMoves;
    }
}