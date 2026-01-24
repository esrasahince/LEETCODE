public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        //totalsum
        //maxsum
        //min sum

      int maxsum=nums[0];
    int minsum=nums[0];
int maxcurrent=nums[0];
int mincurrent=nums[0];
int totalsum = nums[0];

        for(int i=1;i<nums.Length;i++)
        {
            totalsum+=nums[i];
            maxcurrent=Math.Max(maxcurrent+nums[i],nums[i]);
            mincurrent=Math.Min(mincurrent+nums[i],nums[i]);
            maxsum=Math.Max(maxsum,maxcurrent);
            minsum=Math.Min(minsum,mincurrent);
        }
        // all numbers negative case
        if (maxsum < 0)
            return maxsum;
        int result=Math.Max(maxsum,totalsum-minsum);
        return result;


        
    }
}