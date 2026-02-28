
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
    public int MaxDepth(TreeNode root)
    {
        int count = 0;
        int max_count = 0;
        traversal(root, count, ref max_count);
        return max_count;
    }
    void traversal(TreeNode node,int count ,ref int max_count)
    {
        if(node == null) return;
        count++;
        if(count> max_count)
            max_count = count;
        traversal(node.left, count, ref max_count);
        traversal(node.right, count, ref max_count);
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}