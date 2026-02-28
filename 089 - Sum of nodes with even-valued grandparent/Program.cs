
 public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
      {
        this.val = val;
        this.left = left;
        this.right = right;
      }
}

public class Solution
{
    public int SumEvenGrandparent(TreeNode root)
    {
        int sum = 0;
        traversal(root, null,ref sum);
        return sum;
    }
    void traversal(TreeNode parent, TreeNode grandparent, ref int sum)
    {
        if (parent == null) return;
        if (grandparent != null && (grandparent.val % 2 == 0))
        {
            if (parent.left != null)
                sum += parent.left.val;
            if (parent.right != null)
                sum += parent.right.val;
        }
        traversal(parent.left, parent, ref sum);
        traversal(parent.right, parent, ref sum);
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}