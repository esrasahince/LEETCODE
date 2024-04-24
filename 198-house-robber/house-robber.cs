public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length<=1)
        return nums[0];
        if(nums.Length==2)
        return Math.Max(nums[0],nums[1]);
       
            for (int i = nums.Length - 3; i >= 0; i--)
        {  if (i == nums.Length - 3)
                nums[i] = nums[i] + nums[i + 2];
           else

            nums[i] = nums[i] + Math.Max(nums[i + 2], nums[i + 3]);
        }
        return nums.ToList().Max();

    }
}