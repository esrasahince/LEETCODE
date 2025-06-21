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
        /*Buradaki prefix sum'ın bir dizide yaptığımızdan hiçbir farkı yok
        Geçtiğimiz yol boyunca prefix sum yapıyoruz, Ama yol bitip geriye döndüğümüz
        için BackTracking yapmak lazım */
        Dictionary<long,int>dict=new();
        dict[0]=1;
        return PrefixSum(root,(long)targetSum,0,dict);
        
    }
    public int PrefixSum(TreeNode node,long target,long currentsum,Dictionary<long,int> dict)
    {
        if(node==null)
        return 0;

        currentsum+=node.val;
        int count=0;
        long remain=currentsum-target;
        if(dict.ContainsKey(remain))
        {
            count+=dict[remain];
        }
        if(dict.ContainsKey(currentsum))
        {
            dict[currentsum]++;
        }
        else
        dict[currentsum]=1;

        count+=PrefixSum(node.left,target,currentsum,dict);
        count+=PrefixSum(node.right,target,currentsum,dict);

        //REMOVE
        dict[currentsum]--;
        if(dict[currentsum]<=0)
        dict.Remove(currentsum);

        return count;



    }
}