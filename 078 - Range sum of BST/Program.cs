using System.ComponentModel.Design;

class Parogram
{
    static void Main(string[] args)
    {

    }
}

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
    TreeNode newRoot;
    TreeNode temp;
    int sum = 0;
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        if (root == null) return 0;
        TreeNode temp = root;
        InOrder(root,low,high);
        return sum;
    }
    void InOrder(TreeNode node ,int low ,int high)
    {
        if (node.left != null && node.val >= low)
        {
            InOrder(node.left, low, high);
        }
        
        if (node.val >= low && node.val <= high)
        {
            sum += node.val;
        }
        if (node.right != null && node.val <= high)
        {

            InOrder(node.right,low, high);
        }

    }
    
    
}