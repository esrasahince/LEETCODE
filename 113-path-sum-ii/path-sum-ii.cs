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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        List<IList<int>> result=new();
        List<int> temp=new();
        DFS(root,targetSum,result,temp);
        return result;
        
    }

    public void DFS(TreeNode root,int target,List<IList<int>> result,List<int> temp)
    {
        if(root==null)
        return;
        temp.Add(root.val);
        if(root.left==null&&root.right==null)
        {
            if(target==root.val)
            result.Add(new List<int>(temp));
           
        }
        else
        {
        DFS(root.left,target-root.val,result,temp);
        DFS(root.right,target-root.val,result,temp);
        }
        temp.RemoveAt(temp.Count-1);
    }
}