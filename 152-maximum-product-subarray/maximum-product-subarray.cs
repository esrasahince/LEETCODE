public class Solution {
    public int MaxProduct(int[] nums) {

     //sayı negatifse o ana kadarki negatif olanı baz alcaz ki max olsun
     
     int currentmin=nums[0];
     int currentmax=nums[0];
     int result=nums[0];
     for(int i=1;i<nums.Length;i++)
     {
        
        if(nums[i]<0)
        {
            (currentmin,currentmax)=(currentmax,currentmin);
            
        }
        currentmin=Math.Min(nums[i],nums[i]*currentmin);
        currentmax=Math.Max(nums[i],nums[i]*currentmax);
        
        result=Math.Max(currentmax, result);

     }
     return result;
        
    }
}