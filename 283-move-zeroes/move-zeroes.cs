public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Length<=1)
        return;
      
        int left=0;
        int right=0;
        while(left<=right&&right<nums.Length)
        {
           
            int temp=nums[left];
            nums[left]=nums[right];
            nums[right]=temp;
             if(nums[left]!=0)
            left++;
            right++;
        }
       
        
    }
}