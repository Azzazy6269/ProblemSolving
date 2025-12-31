class Program
{
    static void Main(string[] args)
    {
        ListNode l1 = new ListNode(2,
            new ListNode(4,
                new ListNode(3)
                )
            );
        ListNode l2 = new ListNode(5,
            new ListNode(6,
                new ListNode(4)
                )
            );
        Solution s =new Solution();
        ListNode result= s.AddTwoNumbers(l1,l2);
        while (result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        ListNode temp1 = l1;
        ListNode temp2 = l2;
        int sum = 0;
        int carry = 0;
        while (temp1!=null || temp2!=null || carry !=0)
        {
            current.next = new ListNode();
            current = current.next;
            sum = carry;
            if (temp1 != null)
            {
                sum += temp1.val;
                temp1 = temp1.next;
            }
            if (temp2 != null)
            { 
                sum += temp2.val;
                temp2 = temp2.next;
            }
            carry = sum / 10;
            current.val = sum%10;
        }

        return dummy.next;
    }
}
