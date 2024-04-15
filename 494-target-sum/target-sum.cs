public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
int result=0;
int sum=0;
      BackTracking(nums,0,target, sum,ref result);
      return result;
        
    }
    public void BackTracking(int[] nums, int start, int target,  int sum, ref int count)
    {
      if(start==nums.Length)
      {if(sum==target)
         {
          count++;
         }
          

          return;
      }
     
        BackTracking(nums,start+1,target, sum+nums[start],ref count);
        BackTracking(nums,start+1,target,sum-nums[start],ref count);
      
      

    }
}