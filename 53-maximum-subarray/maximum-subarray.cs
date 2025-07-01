public class Solution {
    public int MaxSubArray(int[] nums) {
        int max=nums[0];
        int sum=nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            sum=Math.Max(nums[i],sum+nums[i]);
            max=Math.Max(sum,max);
        }
        return max;
        
    }
}