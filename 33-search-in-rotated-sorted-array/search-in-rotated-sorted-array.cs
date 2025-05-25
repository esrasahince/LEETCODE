public class Solution {
    public int Search(int[] nums, int target) {
        int minindex=FindIndexOfMinimum(nums);
        Console.Write(minindex);
        int firstpart=BinarySearch(nums,target,minindex,nums.Length-1);
       if(firstpart!=-1)
       return firstpart;

        int secondpart=BinarySearch(nums,target,0,minindex-1);
         if(secondpart!=-1)
       return secondpart;

       return -1;

        
    }
    public int FindIndexOfMinimum(int[] nums)
    {
        int left=0;
        int right=nums.Length-1;
        while(left<right)
        {
            if(nums[left]<nums[right])
            return left;
            int middle=left+(right-left)/2;
            if(nums[middle]>nums[right])
            left=middle+1;
            else if(nums[middle]<nums[left])
            right=middle;
        }
        return left;
    }
    public int BinarySearch(int[] nums,int target, int left,int right)
    {
        
        while(left<=right)
        {
            int middle=left+(right-left)/2;
            if(nums[middle]==target)
            return middle;
            if(nums[middle]<target)
            left=middle+1;
            else
            right=middle-1;
        }
        return -1;

    }
}