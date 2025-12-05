
// Definition for singly-linked list.
using System.Security.Cryptography;

public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode previous = null,
        temp = head,
        next;

        while (temp != null)
        {
            next = temp.next;
            temp.next = previous;
            previous = temp;
            temp = next;

        }
        head = previous;
        temp = head;
        while (temp != null)
        {
            temp = temp.next;
        }

        return head;
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}