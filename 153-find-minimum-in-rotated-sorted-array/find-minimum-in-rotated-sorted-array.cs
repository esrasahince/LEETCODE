public class Solution {
    public int FindMin(int[] nums) {

        //normally nums[right]>nums[middle] , 
        //if  nums[right]<nums[middle] search space [middle+1, right]
        if(nums.Length==1)
        return nums[0];
        int left=0;
        int right=nums.Length-1;
        int middle=0;
        while(left<right)
        {
            middle=left+(right-left)/2;
            if(nums[right]<nums[middle])
            {
                left=middle+1;
            }
            else
            {
                right=middle;
            }
        }
        return nums[left];

        
    }
}