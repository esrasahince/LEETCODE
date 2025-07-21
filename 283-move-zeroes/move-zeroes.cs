public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Length<=1)
        return;
        int left=0;
        for(int right=0;right<nums.Length;right++)
        {
            if(nums[right]!=0)
            {
                int temp=nums[right];
                nums[right]=nums[left];
                nums[left]=temp;
               
                left++;
                
            }
          
        }
       
        
        
    }
}