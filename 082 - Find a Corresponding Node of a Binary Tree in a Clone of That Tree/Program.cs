
public class TreeNode
{
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int x) { val = x; }
}


public class Solution
{
    TreeNode result;
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        InOrder(cloned, target);
        return result;
    }
    void InOrder(TreeNode node,TreeNode target)
    {
        if (node == null) return;
        InOrder(node.left,target);
        if(node.val == target.val)
        {
            result = node;
            return;
        }
        InOrder(node.right,target);
    }
}

class Program
{
    static void Main(string[] args)
    {

    }
}