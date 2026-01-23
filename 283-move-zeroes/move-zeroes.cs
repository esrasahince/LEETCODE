public class Solution {
    public void MoveZeroes(int[] nums) {
        int left=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
            {
                nums[left]=nums[i];
                left++;
            }
        }
        while(left<nums.Length)
        {nums[left]=0;
        left++;}
        
    }
}