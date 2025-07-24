public class Solution {
    public int Search(int[] nums, int target) {
        //target direk soruluyor  varlığından eminiz
        //template 1
        int left=0;
        int right=nums.Length-1;
        while(left<=right)
        {

            int middle=left+(right-left)/2;
            if(nums[middle]==target)
            return middle;
            if(nums[middle]<nums[right]) // sağ taraf sıralı
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
            else //sol taraf sıralı
            {
                if(target<nums[middle]&&target>=nums[left])
                {
                    right=middle-1;
                }
                else
                {
                    left=middle+1;
                }

            }
        }
        return -1;
        
    }
}