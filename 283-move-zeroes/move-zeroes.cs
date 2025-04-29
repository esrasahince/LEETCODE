public class Solution {
    public void MoveZeroes(int[] nums) {
        
        
        int zeroind=0;
        bool check=false;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0&&!check)
            {
                zeroind=i;
                check=true;
            }
            if(check&&nums[i]!=0)
            {
                nums[zeroind]=nums[i];
                nums[i]=0;
                if(zeroind+1<nums.Length)
                {
                    zeroind++;
                }
                else
                check=false;
            }
        }
    }
}