class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();
        s.HasCycle(new ListNode(1));
    }
}


  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
 
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if(head == null) return false;
        ListNode slow = head;
        ListNode fast = head.next;
        while (slow != fast && fast!=null) 
        {
            slow = slow.next;
            if (fast != null)
            {
                fast = fast.next;
            }
            if (fast != null)
            {
                fast = fast.next;
            }
        }
        if(fast ==null )
            return false; 
        return true;
        

    }
}