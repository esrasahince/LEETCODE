public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length==0)
        return 0;
        if(nums.Length==1)
        return nums[0];
        Dictionary<int,int> memo=new();
        return TopDown(nums,nums.Length-1,memo);
        
    }
    public int TopDown(int[] nums, int origin,Dictionary<int,int> memo)
    {
        if(origin<0)
        return 0;
     
        if(memo.ContainsKey(origin))
        return memo[origin];
        int include=nums[origin]+TopDown(nums,origin-2,memo);
        int exclude=TopDown(nums,origin-1,memo);
        memo[origin]=Math.Max(include,exclude);
        return memo[origin];
    }
}