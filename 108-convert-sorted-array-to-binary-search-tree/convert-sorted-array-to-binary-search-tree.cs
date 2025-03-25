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

        if(nums==null||nums.Length==0)
            return new TreeNode();
        if(nums.Length==1)
            return new TreeNode(nums[0]);
        int left=0;
        int right=nums.Length-1;
    
        return Insert(nums,left,right);

        
}

    public TreeNode Insert(int[] nums,int left, int right) {
        
        if(left>right)
        return null;

        int middle=(right-left)/2+left;
        TreeNode root=new TreeNode(nums[middle]);
        root.left=Insert(nums,left,middle-1);
        root.right=Insert(nums,middle+1,right);
        return root;
    
       


   
    }


}