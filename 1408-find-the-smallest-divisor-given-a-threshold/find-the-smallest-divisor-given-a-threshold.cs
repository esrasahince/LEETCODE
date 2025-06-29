public class Solution {
    public int SmallestDivisor(int[] nums, int threshold) {
        int left=1;
        int right=nums.Max();
        while(left<right)
        {
            int middle=left+(right-left)/2;
            int result=CalculateSum(nums,middle);
            if(result>threshold)
            {
                left=middle+1;
            }
            else
            right=middle;
        }
        return right;
        
    }
    public int CalculateSum(int[] nums,int divisor)
    {
        double result=0;
        foreach(int i in nums)
        { 
           result+=Math.Ceiling((double)i/divisor);
        }
        return (int)result;
    }
}