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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int lastindex=preorder.Length-1;
        return Construct(preorder,inorder,0,lastindex,0,lastindex);
        
    }

    public TreeNode Construct(int[] preorder, int[] inorder,int pstart,int pend,int istart,int iend)
    {
        if(pstart>pend||istart>iend)
        return null;

        TreeNode root=new TreeNode(preorder[pstart]);
        int index=Array.IndexOf(inorder,preorder[pstart]);
        int itemcount=index-istart;

        root.left=Construct(preorder,inorder,pstart+1,pstart+itemcount,istart,index-1);
        root.right=Construct(preorder,inorder,pstart+itemcount+1,pend,index+1,iend);
        return root;
    }
}