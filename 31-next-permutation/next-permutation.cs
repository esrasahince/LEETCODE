public class Solution {
    public void NextPermutation(int[] nums) {
    if(nums.Length<=1)
    return;
    
    int right=nums.Length-2;
    while(right>=0&&nums[right]>=nums[right+1])
    {
        right--;
    }
    //right is the pivot point,
        // If no pivot found, array is in descending order
        if(right < 0) {
            Reverse(nums, 0);
            return;
        }
    int left=nums.Length-1;
    
    while(left>right&&nums[right]>=nums[left])
    {
       
       left--;
    }
    Swap(nums,right,left);
    Reverse(nums,right+1);        
    }
    public void Swap(int[] nums,int left,int right)
    {
        int temp=nums[right];
        nums[right]=nums[left];
        nums[left]=temp;
    }
    public void Reverse(int[] nums, int start)
    {
        int end=nums.Length-1;
        while(start<end)
        {
            int temp=nums[end];
            nums[end]= nums[start];
            nums[start]=temp;
            start++;
            end--;
        }
    }
}