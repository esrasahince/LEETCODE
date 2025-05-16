public class Solution {
    public bool CanPartition(int[] nums) {
        // Calculate total sum of all elements
        int totalSum = 0;
        foreach (int num in nums) {
            totalSum += num;
        }
        
        // If totalSum is odd, we cannot partition into two equal subsets
        if (totalSum % 2 != 0) {
            return false;
        }
        
        // We need to find if a subset can sum up to totalSum/2
        int targetSum = totalSum / 2;
        
        // Use a dictionary to memoize our results
        // Key: (index, currentSum), Value: bool result
        Dictionary<(int, int), bool> memo = new Dictionary<(int, int), bool>();
        
        return TopDown(nums, nums.Length - 1, targetSum, memo);   
    }
    
    public bool TopDown(int[] nums, int index, int remainingSum, Dictionary<(int, int), bool> memo) {
        // Base cases
        if (remainingSum == 0) {
            return true; // We've found a valid subset
        }
        
        if (index < 0 || remainingSum < 0) {
            return false; // We've either used all items or exceeded our target sum
        }
        
        // Check if we've already computed this state
        if (memo.ContainsKey((index, remainingSum))) {
            return memo[(index, remainingSum)];
        }
        
        // Decision: either include the current element or exclude it
        bool result;
        
        // If current element is larger than the remaining sum, we can only exclude it
        if (nums[index] > remainingSum) {
            result = TopDown(nums, index - 1, remainingSum, memo);
        } else {
            // Try both including and excluding the current element
            result = TopDown(nums, index - 1, remainingSum - nums[index], memo) || 
                    TopDown(nums, index - 1, remainingSum, memo);
        }
        
        // Memoize the result
        memo[(index, remainingSum)] = result;
        return result;
    }
}