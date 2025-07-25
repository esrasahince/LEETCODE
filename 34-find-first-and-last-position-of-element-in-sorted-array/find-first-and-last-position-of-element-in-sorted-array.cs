public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {  if (nums == null || nums.Length == 0)
            return new int[] { -1, -1 };
        int first = FindFirstOccurence(nums, target);
        int last = FindLastOccurence(nums, target);
        return new int[2] { first, last };
    }
    public int FindFirstOccurence(int[] nums, int target)
    {
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
        return nums[left]==target?left:-1;
    }
    public int FindLastOccurence(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left < right)
        {
            int middle = left + (right - left + 1) / 2;
            if (nums[middle] > target)
            {
                right = middle - 1;
            }
            else
            {
                left = middle;
            }
        }
        return nums[left]==target ? left : -1;
    }
}