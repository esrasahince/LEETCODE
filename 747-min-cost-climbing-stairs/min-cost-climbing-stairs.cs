public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if(cost==null)
        return 0;
        if(cost.Length==1)
        return cost[0];

        Dictionary<int,int> memo=new();
        return Math.Min(TopDown(cost,0,memo),TopDown(cost,1,memo));
        
    }
    public int TopDown(int[] cost,int index,Dictionary<int,int> memo)
    {
        if(index>=cost.Length)
        return 0;
        if(memo.ContainsKey(index))
        return memo[index];
      

        memo[index]=Math.Min(TopDown(cost,index+1,memo),TopDown(cost,index+2,memo))+cost[index];
        return memo[index];
    }
}