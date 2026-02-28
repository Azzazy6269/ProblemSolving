
using System.Xml.Linq;

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
    public TreeNode newRoot;
    public TreeNode temp;
    int sum = 0;
    public TreeNode BstToGst(TreeNode root)
    {
        temp= root;
        InOrder(root);
        return root;
    }
    void InOrder(TreeNode p)
    {
        if (p == null) return;
        InOrder(p.right);
        sum += p.val;
        p.val = sum;
        InOrder(p.left);
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}