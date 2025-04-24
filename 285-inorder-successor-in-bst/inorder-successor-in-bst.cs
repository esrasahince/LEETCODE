/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        List<TreeNode> result=new();

         InOrderSearch(root,result);
         int index=0;
        foreach(TreeNode item in result)
        {
            if(item.val==p.val)
            {
                index=result.IndexOf(item);
                break;

            }
        }
        
         return index+1<result.Count?result[index+1]:null;


        
    }
    public void InOrderSearch(TreeNode node,List<TreeNode> result)
    {
        if(node==null)
        return;
        InOrderSearch(node.left,result);
        result.Add(node);
        InOrderSearch(node.right,result);
        


    }
}