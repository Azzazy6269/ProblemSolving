
class Program
{
    static void Main(string[] args)
    {

    }
}
  public class ListNode
{
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
  }

public class Solution
{
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        ListNode temp = list1; 
        int count = 0;
        while (temp != null && count < a-1) 
        {
            temp = temp.next;
            count++;
        }
        ListNode before_a = temp;
        while(temp != null && count <b)
        {
            temp = temp.next;
            count++;
        }
        ListNode after_b = temp.next;
        before_a.next = list2;
        ListNode temp2 = list2;
        while (temp2.next != null )
        {
            temp2 = temp2.next;
        }
        temp2.next = after_b;
        return list1;
    }
}