public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums==null||nums.Length<1)
        return new int[2]{-1,-1};
        
        int first=FirstPosition(nums,target);
        int last=LastPosition(nums,target);
        return new int[2]{first,last};
        
    }
    public int FirstPosition(int[] nums,int target)
    {
        int left=0;
        int right=nums.Length-1;
        while(left<right)
        {
            int middle=left+(right-left)/2;
           
            if(nums[middle]<target)
            left=middle+1;
            else
            right=middle;
        }
        //left==right durumunda döngü bitti
        return nums[left]==target?left:-1;

    }
     public int LastPosition(int[] nums,int target)
    {
        int left=0;
        int right=nums.Length-1;
        int lastoccurence=-1;
        while(left<=right)
        {
            int middle=left+(right-left)/2;
          
            if(nums[middle]==target)
            {
                lastoccurence=middle;
                left=middle+1;
            }
            else if(nums[middle]<target)
            left=middle+1;
            else
            right=middle-1;
        }
        
        return lastoccurence;
}}