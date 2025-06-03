public class Solution {
    public int LongestOnes(int[] nums, int k) {
        if(nums==null||nums.Length==0)
        return 0;
        int left=0;
        int result=0;
        for(int right=0;right<nums.Length;right++)
        {
            if(nums[right]==0)
            {
                k--;
                while(k<0&&left<nums.Length)
                { if(nums[left]==0)
                    k++;
                    left++;
                }
            }
            result=Math.Max(result,right-left+1);
        }
        return result;
        
    }
}