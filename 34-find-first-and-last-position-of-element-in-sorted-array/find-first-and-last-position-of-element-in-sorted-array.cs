public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length == 0)
        return new int[] { -1, -1 };
        int left=FindUpperBound(nums,target);
        int right=FindLowerBound(nums,target);
        return new int[2]{left,right};
        
    }

    public int FindUpperBound(int[] nums, int target)
    {
        int left=0;
        int right=nums.Length-1;
        int middle=0;
        while(left<right)
        {
            middle=left+(right-left)/2;
            if(target<=nums[middle])
            right=middle;
            else
            left=middle+1;
        }
        return nums[left]==target?left:-1;

    }
    public int FindLowerBound(int[] nums, int target)
    {
        int left=0;
        int right=nums.Length-1;
        int middle=0;
        while(left<right)
        {
            middle=left+(right-left+1)/2;
            if(target<nums[middle])
            right=middle-1;
            else
            left=middle;
        }
        return nums[left]==target?left:-1;

    }
}