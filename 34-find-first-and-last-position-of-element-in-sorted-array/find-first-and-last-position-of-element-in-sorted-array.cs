public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums.Length==1&&target==nums[0])
         return new int[2];
        if(nums==null||nums.Length==0)
           return new int[]{-1,-1};
        
        int[] result=new int[2];
        result[0]=FindFirst(nums,target);
        result[1]=FindLast(nums,target);
        
     return result;
        
    }

    public int FindLast(int[] nums, int target)
    {
        int left=0;
        int right=nums.Length-1;
        int result=-1;
        while(left<=right)
        {
            int middle=left+(right-left)/2;
            if(nums[middle]==target)
            { 
                result=middle;
                left=middle+1;
                
            }
          
            else if(nums[middle]<target)
            {
                left=middle+1;
            }
            else
            right=middle-1;
        }
        return result;
    }
    public int FindFirst(int[] nums, int target)
    {
        int left=0;
        int right=nums.Length-1;
        int result=-1;
        while(left<=right)
        {
            int middle=left+(right-left)/2;
            if(nums[middle]==target)
            { 
                result=middle;
                right=middle-1;
                
            }
          
            else if(nums[middle]<target)
            {
                left=middle+1;
            }
            else
            right=middle-1;
        }
        return result;
    }
    
}