public class Solution {
    public int Search(int[] nums, int target) {
         if(nums.Length==0)
         return -1;
      
        int left=0;
        int right=nums.Length-1;
        int middle=0;
        while(left<=right)
        {
            middle=left+(right-left)/2;
            if(nums[middle]==target)
            return middle;

           if(nums[left]<=nums[middle]) //left side sorted
           {
            if(target>=nums[left]&&target<nums[middle])
            {
                right=middle-1;
            }
            else
            {
                left=middle+1;
            }

           }
           else  //right side sorted
           {
             if(target>nums[middle]&&target<=nums[right])
            {
                left=middle+1;
            }
            else
            {
                right=middle-1;
            }


           }
            
        
        }
        return -1;

    
        
    }
}