public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {

        int n=nums1.Length;
        int m=nums2.Length;
        
        int[] prev=new int[m+1];
        
        int max=0;
        for(int i=1;i<n+1;i++)
        {
            int[] current=new int[m+1];
            for(int j=1;j<m+1;j++)
            {
                if(nums1[i-1]==nums2[j-1])
                {
                    current[j]=1+prev[j-1];
                    max=Math.Max(max,current[j]);
                }
                else
                {
                    current[j]=0;
                }
            }
            prev=current;
        }
        return max;
        
    }
}