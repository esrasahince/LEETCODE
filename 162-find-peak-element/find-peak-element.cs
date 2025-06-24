public class Solution {
    public int FindPeakElement(int[] nums) {

      int left=0;
      int right=nums.Length-1;
      while(left+1<right)
      {
        int middle=left+(right-left)/2;
        if(nums[middle]<nums[middle+1])
        left=middle;
        else
        right=middle;
      }
          return nums[left] > nums[right] ? left : right;
 
        
    }
}