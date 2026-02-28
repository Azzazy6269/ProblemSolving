class Program
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
    TreeNode temp ;
    public TreeNode IncreasingBST(TreeNode root)
    {
        InOrder(root);
        return newRoot;
    }
    void InOrder(TreeNode node)
    {
        if(node!=null){
            InOrder(node.left);
            node.left = null;
            if(newRoot == null)
            {
                newRoot = node;
                temp = newRoot;
            }
            else
            {
                temp.right = node;
                temp = temp.right;
            }
            InOrder(node.right);
        }
      
    }
}