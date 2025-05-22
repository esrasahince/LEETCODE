public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {

        int n=nums1.Length;
        int m=nums2.Length;
        
        int[,] dp=new int[n+1,m+1];
        int max=0;
        for(int i=1;i<n+1;i++)
        {
            for(int j=1;j<m+1;j++)
            {
                if(nums1[i-1]==nums2[j-1])
                {
                    dp[i,j]=1+dp[i-1,j-1];
                    max=Math.Max(max,dp[i,j]);
                }
                else
                {
                    dp[i,j]=0;
                }
            }
        }
        return max;
        
    }
}