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
    public int AverageOfSubtree(TreeNode root)
    {
        int count =0;
        ExploreNode(root,ref count);
        return count;
    }
    int[] ExploreNode(TreeNode node , ref int count)
    {
        if(node == null) return new int[] {0,0};
        int [] right = ExploreNode(node.right ,ref count);
        int [] left = ExploreNode(node.left,ref count);
        int [] result = new int[] { right[0] + left[0]+ node.val , right[1] + left[1] +1 };//{sum , num of nodes}
        if (result[0] / result[1] == node.val)
        {
            count++;
        }
        return result;

    }
}