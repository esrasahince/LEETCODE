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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        List<TreeNode> pathToP = new List<TreeNode>();
        List<TreeNode> pathToQ = new List<TreeNode>();

        BackTrack(root, p, pathToP);
        BackTrack(root, q, pathToQ);

        Console.WriteLine("Path to p:");
        foreach (var node in pathToP) {
            Console.Write(node.val + " ");
        }
        Console.WriteLine();
        
        Console.WriteLine("Path to q:");
        foreach (var node in pathToQ) {
            Console.Write(node.val + " ");
        }
        Console.WriteLine();

        var commonPath = pathToP.Intersect(pathToQ).ToList();
        return commonPath[commonPath.Count-1];
    }
    
    public bool BackTrack(TreeNode root, TreeNode node, List<TreeNode> path) {
        if (root == null)
            return false;

        path.Add(root);

        if (root.val == node.val)
            return true;

        if (BackTrack(root.left, node, path) || BackTrack(root.right, node, path))
            return true;

        path.RemoveAt(path.Count - 1);
        return false;
    }
    }
