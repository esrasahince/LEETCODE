public class Solution {
    public void NextPermutation(int[] nums) {
        if(nums.Length<2)
        return;
        int left = nums.Length - 2;
        int right = nums.Length - 1;
       
        

        // Find first pair from the end where nums[left] < nums[right]
        while (left >= 0 && nums[left] >= nums[right]) {
            left--;
            right--;
        }
         
        if (left >= 0) {
            // Pivot found at left
            right = nums.Length - 1;
            while (left < right) {
                if (nums[right] > nums[left]) {
                    Swap(nums, left, right);
                    Reverse(nums, left + 1, nums.Length - 1);
                    return; // Important: exit after processing pivot
                }
                right--;
            }
        }

        // Only reached if no pivot found - reverse entire array
        Reverse(nums, 0, nums.Length - 1);
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            Swap(nums, start, end);
            start++;
            end--;
        }
    }
}