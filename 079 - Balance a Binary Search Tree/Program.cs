using System.Xml.Linq;

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
    List<int> nodes = new List<int>();

    public TreeNode BalanceBST(TreeNode root)
    {
        InOrder(root);
        return Build(0, nodes.Count - 1);
    }

    TreeNode Build(int left, int right)
    {
        if (left > right)
            return null;

        int mid = (left + right) / 2;
        TreeNode node = new TreeNode(nodes[mid]);

        node.left = Build(left, mid - 1);
        node.right = Build(mid + 1, right);

        return node;
    }

    void InOrder(TreeNode p)
    {
        if (p == null) return;
        InOrder(p.left);
        nodes.Add(p.val);
        InOrder(p.right);
    }
}
