public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if(cost==null)
        return 0;
        if(cost.Length==1)
        return cost[0];
        int first=cost[0];
        int second=cost[1];
        int current=Math.Min(first,second);
     
        for(int i=2;i<cost.Length;i++)
        {
           current=Math.Min(first,second)+cost[i];
           first=second;
           second=current;

        }
        return Math.Min(first,second);

        
    }
}