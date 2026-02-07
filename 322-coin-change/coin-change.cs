public class Solution {
    public int CoinChange(int[] coins, int amount) {

        int n = coins.Length;
            int[,] dp = new int[n + 1, amount + 1];

            for(int i=0;i<n+1; i++)
            {
                for(int j=0;j<amount+1;j++)
                {
                    if(j==0)
                    {
                        //capacity 0 ken 0 tane coin kullanırım
                        dp[i, 0] = 0;

                    }
                    else if(i==0) //elimde hic coin yoksa  capacity 5 için kac coin kullanırdım? kullanamazdım bunu olusturmam imkansız
                    {
                        dp[0, j] = int.MaxValue-1;

                    }
                    else
                    {

                        if (coins[i-1]<=j)
                        {
                            //1. add
                            int include = 1 + dp[i, j - coins[i-1]];
                            int exclude = dp[i - 1, j];
                            dp[i, j] = Math.Min(include, exclude);
                        }
                        else
                        {
                          
                            dp[i, j] = dp[i - 1, j];

                        }
                    }
                    
                }
            
            
            }
            return dp[n, amount]>=int.MaxValue-1?-1:dp[n,amount];
        
    }
}