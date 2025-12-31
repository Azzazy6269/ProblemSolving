class Program
{
    static void Main(string[] args)
    {
        ListNode head = new ListNode(-1,
            new ListNode(5,
                new ListNode(3,
                    new ListNode(4,new ListNode(0)))));

        Console.WriteLine("Before sorting:");
        PrintList(head);

        Solution solution = new Solution();
        head = solution.InsertionSortList(head);

        Console.WriteLine("After sorting:");
        PrintList(head);
    }

    public static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val);
            if (head.next != null)
                Console.Write(" -> ");
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
    public ListNode InsertionSortList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        ListNode dummy = new ListNode(0);
        ListNode current = head;
        ListNode next = current.next;
        while (current != null)
        {
            next = current.next;
            ListNode temp = dummy;
            while(temp.next != null &&temp.next.val < current.val)
            {
               temp = temp.next;
            }
            ListNode biggerNode = temp.next;
            temp.next = current;
            current.next = biggerNode;
            current = next;

        }
        return dummy.next;
    }
}
