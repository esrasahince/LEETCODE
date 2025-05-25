public class Solution {
    public int FindMin(int[] nums) {

        if(nums.Length==1)
        return nums[0];
        int left=0;
        int right=nums.Length-1;
        while(left<right)
        {
            if(nums[left]<=nums[right])
            return nums[left];

            int middle=left+(right-left)/2;
        

            if(nums[middle]>nums[right])
            {
                left=middle+1;
            }
            else if(nums[middle]<nums[left])
            {
                right=middle;
            }

        }
        return nums[left];

        
    }
}