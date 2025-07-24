public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        int right = nums.Length - 1;
        int left = 0;
        while (left <= right)
        {
            int middle = left + (right - left+1) / 2;
            if (nums[middle] == target)
                return middle;
            else if (nums[middle] > target)
                right = middle - 1;
            else
                left = middle + 1;

        }
        //right ==left oldugunda dongu biter
        return right+1;
        
    }
}