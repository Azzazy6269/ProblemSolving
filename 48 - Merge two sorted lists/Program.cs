class Program
{
    static void Main(string[] args)
    {
        Solution s = new Solution();

        ListNode list1 = BuildList(new int[] { 1, 2, 4 });
        ListNode list2 = BuildList(new int[] { 1, 3, 4 });

        ListNode result = s.MergeTwoLists(list1, list2);

        PrintList(result);
    }

    static ListNode BuildList(int[] values)
    {
        if (values.Length == 0) return null;

        ListNode head = new ListNode(values[0]);
        ListNode current = head;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }

        return head;
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        
        ListNode newHead = null;
        ListNode temp1 = list1;
        ListNode temp2 = list2;
        ListNode newTemp = new ListNode();

        while (temp1 != null && temp2 != null)
        {
            if (newHead == null)
            {
                if (temp1.val < temp2.val)
                {
                    newHead = temp1;
                    temp1 = temp1.next;
                }
                else
                {
                    newHead = temp2;
                    temp2 = temp2.next;
                }
                newTemp = newHead;
                continue;
            }
            if (temp1.val < temp2.val)
            {
                newTemp.next = temp1;
                temp1 = temp1.next;
            }
            else
            {
                newTemp.next = temp2;
                temp2 = temp2.next;
            }
            newTemp = newTemp.next;
            
        }
        while(temp1 != null)
        {
            if (newHead == null)
            {
                newHead = temp1;
                temp1 = temp1.next;
                newTemp = newHead;
                continue;
            }
            newTemp.next = temp1;
            newTemp = newTemp.next;
            temp1 = temp1.next;
            
        }
        while (temp2 != null)
        {
            if (newHead == null)
            {
                newHead = temp2;
                temp2 = temp2.next;
                newTemp = newHead;
                continue;
            }
            newTemp.next = temp2;
            newTemp = newTemp.next;
            temp2 = temp2.next;
        }
        return newHead;
    }
}