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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        
        List<LinkedList<int>> result = new();
        List<IList<int>> finalresult = new();
        if(root==null)
        return finalresult;
        Queue<(TreeNode, int)> que = new();
        que.Enqueue((root, 0));
        while (que.Count > 0)
        {
            var (current, level) = que.Dequeue();
            if (result.Count == level)
            {
                result.Add(new LinkedList<int>());
            }
            if (level%2==0)
                result[level].AddFirst(current.val);
            else
                result[level].AddLast(current.val);

            if (current.right != null)
                que.Enqueue((current.right, level + 1));
            if (current.left != null)
                que.Enqueue((current.left, level + 1));
        }


        foreach (var item in result)
        {
            finalresult.Add(item.ToList());
        }
        return finalresult;


    }}