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
    public int PathSum(TreeNode root, int targetSum) {
    int count=0;
    Recursive(root,targetSum,ref count);
    return count;

    
        
    }
    public void Recursive(TreeNode root,  int target,ref int count) 
    {
        if(root==null)
        return;
        Check(root,target,0, ref count);
        Recursive(root.left,target, ref count);
        Recursive(root.right,target, ref count);

    }


        private bool Check(TreeNode root, int target, long currentSum, ref int count) {
        if (root == null) return false;

        currentSum += root.val;

        if (currentSum == target) {
            count++;
        }

        Check(root.left, target, currentSum, ref count);
        Check(root.right, target, currentSum, ref count);

        return true; // This value is not used in the path counting logic, so it can be arbitrary.
    }
}