
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
    public int DeepestLeavesSum(TreeNode root)
    {
        int max_height = 0;
        int sum = 0;
        traversal(root, 0,ref max_height, ref sum);
        return sum;
    }
    void traversal(TreeNode node ,int height ,ref int max_height,ref int sum )
    {
        if(node == null) return;
        height++;
        if (height > max_height)
        {
            sum = 0;
            max_height=height;
        }
        if (max_height == height && node.left ==null && node.right == null)
        {
            sum += node.val;
        }
        traversal(node.left, height, ref max_height, ref sum);
        traversal(node.right, height, ref max_height, ref sum);
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}