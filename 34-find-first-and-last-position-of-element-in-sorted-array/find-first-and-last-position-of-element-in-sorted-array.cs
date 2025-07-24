public class Solution {
    public int[] SearchRange(int[] nums, int target)
    {
        if(nums==null||nums.Length==0)
        return new int[2]{-1,-1};

        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            int middle = left + (right - left) / 2;
            if (target > nums[middle])
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }

        }
        //it ends when left==middle;
        if(nums[left]!=target)
        return new int[2]{-1,-1};
        while (right<nums.Length)
        {
            if(nums[right] != target)
            break;
            right++;
        }
        return new int[2] { left, right-1};
        
    }
}