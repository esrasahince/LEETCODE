public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxsum=nums[0];
        int currentsum=nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            currentsum=Math.Max(nums[i],nums[i]+currentsum);
            maxsum=Math.Max(currentsum,maxsum);
        }
        return maxsum;
    }
}