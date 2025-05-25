public class Solution {
    public bool Search(int[] nums, int target) {
        int right=nums.Length-1;
        int left=0;
        while(left<=right)
        {
            int middle=left+(right-left)/2;
            if(target==nums[middle])
            return true;
            if(nums[middle]<nums[right])
            {
                if (target > nums[middle] && target <= nums[right])
                {
                    left=middle+1;
                }
                else
                {
                    right=middle-1;
                }

            }
            else if(nums[middle]>nums[left])
            {
                if(target<nums[middle]&& target>=nums[left])
                {
                    right=middle-1;
                }
                else
                 left=middle+1;

            }
            else if(nums[middle]==nums[right])
            right--;
            else if(nums[left]==nums[middle])
            left++;
        }
        return false;
        
        
        
    }
}