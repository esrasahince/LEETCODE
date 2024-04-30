public class Solution {
    public int Rob(int[] nums) {
        

    

        return BottomUp(nums);
        
    }
    public int BottomUp(int[] nums)
    {
      for(int i=nums.Length-1;i>=0;i--)
      {
        if(i==nums.Length-2)
        {
            nums[i]=Math.Max(nums[nums.Length-1], nums[i]);
        }
        else if(i<nums.Length-2)
         nums[i]=Math.Max(nums[i]+nums[i+2],nums[i+1]);
        
      }
      
      return nums[0];

    }
}