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
        bool result=false;
	
	return InorderSuccessor(root,p,ref result);
	
        
    }
	public TreeNode InorderSuccessor(TreeNode node, TreeNode p, ref bool result)
	{
	if(node==null)
	return null;

	
	TreeNode leftresult=InorderSuccessor(node.left,p,ref result);
	if(leftresult!=null)
	{
	return leftresult;
	}

    if(result)
	return node;
	if(node.val==p.val)
	result=true;
	TreeNode rightresult=InorderSuccessor(node.right,p,ref result);
	if(rightresult!=null)
	return rightresult;
	
	return null;
	
	
	
	
	
	
	
	}
}