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
    public bool EvaluateTree(TreeNode root)
    {
       PostOrder(root);
        if(root.val == 0 )
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    void PostOrder(TreeNode node)
    {
        if (node == null) return;
        PostOrder(node.left);
        PostOrder(node.right);
        if (node.left != null && node.right != null) 
        {
            if(node.val == 2)
            {
                if (node.left.val == 1 || node.right.val == 1) 
                {
                    node.val = 1;
                }
                else
                {
                    node.val = 0;
                }
            }
            else if (node.val == 3)
            {
                if (node.left.val == 1 && node.right.val == 1)
                {
                    node.val = 1;
                }
                else
                {
                    node.val = 0;
                }
            }

        }

    }
}