public class Solution {

    public int Trap(int[] height) {
	int len=height.Length;
	int[] left=new int[len];
	int[] right=new int[len];
	int result=0;
	int leftmax=0;
	int rightmax=0;
	
	
	for(int i=0;i<len;i++)
	{
	left[i]=leftmax;
	leftmax=Math.Max(height[i],leftmax);
	
	}
    for(int i=len-1;i>=0;i--)
    {
       	right[i]=rightmax;
	    rightmax=Math.Max(height[i],rightmax); 
    }
	for(int i=0;i<len;i++)
	{
	 int temp=Math.Min(left[i],right[i])-height[i];
	 if(temp>0)
	 result+=temp;
	
	}
	return result;
	
	
        
    }
}