public class Solution {
    public int Search(int[] nums, int target) {
        int left=0;
        int right=nums.Length-1;
        int middle=0;
         while(left<=right)
            {
            middle=left+(right-left)/2;

                //no rotate
                if(nums[middle]==target)
                return middle;
                
            if(nums[left]<=nums[middle])
            {

                if(nums[left]<=target&&target<nums[middle])
                right=middle-1;
                else 
                left=middle+1;
            }
            else  if(nums[right]>=nums[middle])
            {
               

                if(nums[right]>=target&&target>nums[middle])
                left=middle+1;
                else 
                right=middle-1;
               
            }
           
        
        }
        
         return -1;}

    }


        
    
