public class Solution {
    public int MaxArea(int[] height) {
        if(height==null||height.Length==0)
        return 0;
        int result=0;
        int leftptr=0;
        int rightptr=height.Length-1;
        while(leftptr<rightptr)
        {
            int dist=rightptr-leftptr;
            int newres=Math.Min(height[leftptr],height[rightptr])*dist;
            result=Math.Max(newres,result);
            if(height[leftptr]<height[rightptr])
            leftptr++;
            else
            rightptr--;
        }
        return result;
        
    }
}