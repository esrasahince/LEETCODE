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
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return null;
        }

        TreeNode root=Helper(0,nums.Length-1,nums);
    return root;

        
    }

 
    public TreeNode Helper(int left, int right, int[] nums)
    {
        if(left>right)
        return null;
        int middle=left+(right-left)/2;
        TreeNode root=new TreeNode(nums[middle]);
        root.left=Helper(left,middle-1,nums);
        root.right=Helper(middle+1,right,nums);
        return root;

    }
}