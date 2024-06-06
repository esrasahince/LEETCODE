/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
      
        Dictionary<string,int>subtree=new();
        List<TreeNode> result=new();
        DFS(root,subtree,result);
        
        return result;
    }
    public string DFS(TreeNode node,Dictionary<string,int> subtree,List<TreeNode> result)
    {
        if(node==null)
        {
            
            return "N";
        }
        StringBuilder str=new();
        str.Append(DFS(node.left,subtree,result)).Append(",");
        str.Append(DFS(node.right,subtree,result)).Append(",");
        str.Append(node.val);
        if(subtree.ContainsKey(str.ToString()))
        {
            subtree[str.ToString()]++;
        }
        else
        {
               subtree[str.ToString()]=1;

        }
     
        if(subtree[str.ToString()]==2)
        result.Add(node);
       return str.ToString();

    }
}