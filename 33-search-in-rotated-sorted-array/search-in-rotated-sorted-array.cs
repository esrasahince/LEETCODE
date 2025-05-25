public class Solution {
    public int Search(int[] nums, int target) {

        int left = 0, right = nums.Length - 1;

        while (left <=right) {
            int middle = left + (right - left) / 2;

            if (nums[middle] == target)
                return middle;

            // Sağ taraf sıralıysa
            if (nums[middle] <=nums[right]) {
                if (target > nums[middle] && target <= nums[right]) {
                    left = middle + 1;
                } else {
                    right = middle - 1;
                }
            }
         

            // Sol taraf sıralıysa
            else if (nums[middle] >= nums[left]) {
                if (target >= nums[left] && target < nums[middle]) {
                    right = middle - 1;
                } else {
                    left = middle + 1;
                }
            }
            

            // Belirsizlik varsa uçları daralt
          
        }

        return -1;
    }
}

        
    
