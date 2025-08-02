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

        List<IList<int>>  result=new();
        List<int> temp=new();
        DFS(root,targetSum,temp,result);
        return result;
        
    }
    public void DFS(TreeNode current, int target, List<int> temp, List<IList<int>>  result)
    {
        if(current==null)
        return;
          temp.Add(current.val);
        if(current.left==null&&current.right==null)
        {
            if(target==current.val)
            {
              
                result.Add(new List<int>(temp));
               

            }
        }
        else
            {
        
            target=target-current.val;
            DFS(current.left,target,temp,result);
            DFS(current.right,target,temp,result);
            }
            temp.RemoveAt(temp.Count-1);
        
    }
}