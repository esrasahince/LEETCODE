public class Solution {
    public int MaxArea(int[] height) {
        int left=0;
        int right=height.Length-1;
        int result=int.MinValue;
        while(left<right)
        {
             int minheight=Math.Min(height[left],height[right]);

             result=Math.Max(result,(right-left)*minheight);
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