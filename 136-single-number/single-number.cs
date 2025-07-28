public class Solution {
    public int SingleNumber(int[] nums) {
        if(nums==null||nums.Length==0)
        return 0;
        
        int result=nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            
            result=result^nums[i];

        }
        return result;
        
    }
}