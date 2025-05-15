public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
      
       int n= nums.Length;
       Dictionary<(int, int), int> memo = new();
       return TopDown(nums,n-1,target,memo);
    }
    public int TopDown(int[] nums, int ind, int target,Dictionary<(int, int), int> memo )
    {
       if(ind < 0)
        return target == 0 ? 1 : 0;//hic eleman kalmamossa ve target 0 a ulasmıssın count 1 artacak.
        if(memo.ContainsKey((ind,target)))
        return memo[(ind,target)];
        
       
            //ekle 
           memo[(ind, target)] = TopDown(nums, ind - 1, target - nums[ind], memo)
                    + TopDown(nums, ind - 1, target + nums[ind], memo);


       
         return memo[(ind,target)];

    }
}