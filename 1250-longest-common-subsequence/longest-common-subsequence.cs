public class Solution {
    public int LongestCommonSubsequence(string s1, string s2) {
        int m=s1.Length;
        int n=s2.Length;
        int[,] dp=new int[m+1,n+1];

        for(int i=1;i<m+1;i++)
        {
            for(int j=1;j<n+1;j++)
            {
                if(s1[i-1]==s2[j-1])
                {
                    dp[i,j]=1+dp[i-1,j-1];
                }
                else
                {
                    dp[i,j]=Math.Max(dp[i,j-1],dp[i-1,j]);

                }
            }
        }

        return dp[m,n];
        
        
    }
}