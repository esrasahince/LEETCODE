public class Solution {
    public int FindMin(int[] nums) {

        //normalde soldakinden büyük sağdakinden kücük
        //minimumda bu denge bozuluyor
        if(nums.Length==1)
        return nums[0];
        int left=0;
        int right=nums.Length-1;
        while(left<=right)
        {
            if(nums[left]<nums[right])
            return nums[left];

            int middle=left+(right-left)/2;
            if(nums[middle]>nums[middle+1])
            return nums[middle+1];
            if(nums[middle]<nums[middle-1])
            return nums[middle];

            if(middle+1<nums.Length&&nums[middle+1]>nums[left])
            {
                left=middle+1;
            }
            else if(middle-1>0&&nums[middle-1]<nums[right])
            {
                right=middle-1;
            }
       

        }
        return nums[0];

        
    }
}