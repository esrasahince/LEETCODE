public class Solution {
    public int FindMin(int[] nums) {
         int left = 0;
    int right = nums.Length - 1;
    while (left < right)
    {
        int middle = left + (right - left) / 2;
        //koşul nedir
        //middle < right olmalı. burdaki durumda 
        //middle>right

        if(nums[middle]>nums[right])
        {
          left=middle+1;
        }
        else
        {
            right=middle;
        }

    }
    //left=rigth oldugunda dongu biter.
    //left kosulu saglayan ilk elemanı  gosterir 
    return nums[left];
        
    }
}