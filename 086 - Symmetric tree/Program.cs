class Program
{
    static void Main(string[] args)
    {

    }
}

public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
     {
         this.val = val;
         this.left = left;
         this.right = right;
     }
}
public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        Queue<(TreeNode t1, TreeNode t2)> nodes = new Queue<(TreeNode t1, TreeNode t2)>();
        nodes.Enqueue((root.left, root.right));
        while (nodes.Count > 0)
        {
            var (t1, t2) = nodes.Dequeue();
            if (t1 == null && t2 == null) continue;  
            if (t1 == null || t2 == null) return false; 
            if (t1.val != t2.val) return false;

            nodes.Enqueue((t1.left, t2.right));
            nodes.Enqueue((t1.right, t2.left));
        }
        return true;
    }
    
}

