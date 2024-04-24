public class Solution {
    public int ClimbStairs(int n) {
       int[] memo=new int[n+1];
        return BottomUp(n,memo);
        
    }

   public  int BottomUp(int n, int[] memo)
    {
        if (n < 2)
            return 1;


        if (memo[n]!=0)
            return memo[n];

        for (int i = 2; i <= n; i++)
        { 
            memo[i] = memo[i]+BottomUp(i -1, memo);
            memo[i] =memo[i]+ BottomUp(i -2, memo);

        }
        return memo[n];

    }
}