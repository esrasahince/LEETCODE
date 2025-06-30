public class Solution {
    public int ThreeSumSmaller(int[] nums, int target) {
        if(nums==null||nums.Length<1)
        return 0;

        Array.Sort(nums);
        int result=0;
        
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1, right = nums.Length - 1;
            
            while (left < right)
            {
                int currentSum = nums[i] + nums[left] + nums[right];
                if(currentSum>=target)
                {
                 
                    right--;
                }
                else
                {
                    result+=right-left;
                   left++;
                  

                }
            }
        }
        return result;
        
    }
}