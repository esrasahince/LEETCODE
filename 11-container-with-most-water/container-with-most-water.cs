public class Solution {
    public int MaxArea(int[] height) {
        int left=0;
        int right=height.Length-1;
        int result=-1;
        while(left<right)
        {
            int area=(right-left)*Math.Min(height[left],height[right]);
            result=Math.Max(result,area);
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