public class Solution {
    public bool Search(int[] nums, int target) {
        int left=0;
        int right=nums.Length-1;
       
        while(left<=right)
        {
            int middle=left+(right-left)/2;
            if(nums[middle]==target)
            return true;
             if (nums[left] == nums[middle] && nums[middle] == nums[right]) {
            left++;
            right--;
        }
            else if(nums[middle]<=nums[right]) //sag taraf sıralı
            {
                if(target>nums[middle]&&target<=nums[right])
                {
                    left=middle+1;
                }
                else
                {
                    right=middle-1;
                }
            }
            else
            {
                if(target<nums[middle]&&target>=nums[left])
                {
                    right=middle-1;
                }
                else
                {
                    left=middle+1;
                    
                }

            }


        }
        return false;
        
    }
}