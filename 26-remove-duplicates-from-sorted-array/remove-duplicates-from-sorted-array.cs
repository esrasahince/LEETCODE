public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int slow=0;
        int fast=0;
        while(fast<nums.Length)
        {
            if(nums[slow]!=nums[fast])
            {
                nums[slow+1]=nums[fast];
                slow++;
            }
            fast++;
        }
        return slow+1;
    }
}