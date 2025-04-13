public class Solution {
    public int MaxArea(int[] height) {
        int min=0;
        int left=0;
        int right=height.Length-1;
        int result=0;
        while(left<right)
        {
            result=Math.Max(result,Math.Min(height[left],height[right])*(right-left));
            if(height[left]<height[right])
            {
                left++;
            }
            else
            {
                right--;
            }

         

            
        }

        return result;
        
    }
}