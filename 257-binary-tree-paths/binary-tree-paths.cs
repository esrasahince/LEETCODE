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
    public IList<string> BinaryTreePaths(TreeNode root) {
        List<string> result=new();
        StringBuilder temp=new();
        DFS(root,temp,result);
        return result;
        
    }
    public void DFS(TreeNode root,StringBuilder temp, List<string> result)
    {
        if(root==null)
        return;
        String s=root.val.ToString();
        temp.Append(root.val);
      
        if(root.left==null&&root.right==null)
        { 
            result.Add(temp.ToString());
        }
        else{
        temp.Append("->");
      
        DFS(root.left,temp,result);
        DFS(root.right,temp,result);
        
       temp.Remove(temp.Length-2,2);
        }
        temp.Remove(temp.Length-s.Length,s.Length);
    }
}