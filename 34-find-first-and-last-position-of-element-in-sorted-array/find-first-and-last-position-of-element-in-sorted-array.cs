public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums.Length==1&&target==nums[0])
         return new int[2];
        if(nums.Length==0||nums==null)
           return new int[]{-1,-1};
        int left=0;
        int right=nums.Length-1;
        int middle=-1;
        while(left<=right)
        {
            middle=left+(right-left)/2;
            if(nums[middle]==target)
            {
                int[] result=new int[2];
                int first=middle;
                int last=middle;
        
                while(first>0&&nums[first-1]==target)
                {
                    first--;
                }
                while(last<nums.Length-1&&nums[last+1]==target)
                {
                    last++;
                }
                result[0]=first;
                result[1]=last;
                return result;
            }
          
            if(nums[middle]<target)
            {
                left=middle+1;
            }
            else
            right=middle-1;
        }
        
        return new int[]{-1,-1};
        
     
        
    }
}