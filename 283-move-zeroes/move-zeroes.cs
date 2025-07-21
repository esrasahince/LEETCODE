public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Length<=1)
        return;
        int left=0;
        for(int right=0;right<nums.Length;right++)
        {
            if(nums[right]!=0)
            {
                nums[left]=nums[right];
               
                left++;
                
            }
          
        }
        while(left<nums.Length)
        {
            nums[left]=0;
            left++;
        }
        
        
    }
}