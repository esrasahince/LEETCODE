public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        if(nums.Length<3)
        return -1;
        Array.Sort(nums);
        int result=int.MaxValue;
        for(int i=0;i<nums.Length-2;i++)
        {
            
            int left=i+1;
            int right=nums.Length-1;
            while(left<right)
            {
                int sum=nums[i]+nums[left]+nums[right];
                if(sum==target)
                return sum;
                if(Math.Abs(result-target)>Math.Abs(sum-target))
                result=sum;
                
                if(sum<target)
                left++;
                else
                right--;
            }
        
        }
            return result;
        
    }
}