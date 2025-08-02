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
    //roottan leafe doğru targeta ulasabilir miyiz
    public bool HasPathSum(TreeNode root, int targetsum) {
        return DFS(root,targetsum);
        
    }

    public bool DFS(TreeNode current,int targetsum)
    {
        if(current==null)
        return false;
        if(current.left==null&current.right==null)
        {
            if(targetsum==current.val)
            return true;
            else return false;
        }
        targetsum-=current.val;
        bool left=DFS(current.left,targetsum);
        bool right=DFS(current.right,targetsum);
        return left||right;
    }
}