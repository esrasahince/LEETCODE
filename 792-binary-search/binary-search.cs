public class Solution {
    public int Search(int[] nums, int target) {
       
        
        int left=0;
        int right=nums.Length-1;
        int middle=0;
       while(left<=right)
       {
            middle=left+(right-left)/2;
            if(target==nums[middle])
            return middle;
            if(target<nums[middle])
            {
                right=middle-1;
            }
            else
            {
                left=middle+1;
            }
        }
        return -1;
        
    }
}