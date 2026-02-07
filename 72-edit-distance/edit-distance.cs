public class Solution {
    public int MinDistance(string text1, string text2) {
        int n = text1.Length;
            int m = text2.Length;
            int[,] dp = new int[n + 1, m + 1];
            for(int i=0;i<n+1;i++)
            {
                dp[i, 0] = i;
            }
            for (int i = 0; i < m + 1; i++)
            {
                dp[0, i] = i;
            }


            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < m + 1; j++)
                {
                    if (text1[i - 1] == text2[j - 1]) //aynıysa bişey yapma
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        int add = dp[i, j - 1];
                        int delete = dp[i - 1, j];
                        int replace = dp[i - 1, j - 1];
                        int temp = Math.Min(add, delete);
                        dp[i, j] = 1 + Math.Min(temp, replace);
                    }
                }
            }
            return dp[n, m];
        
    }
}