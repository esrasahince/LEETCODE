public class Solution {
    public int ClimbStairs(int n) {
        Dictionary<int,int> memo=new();
        return BottomUp(n,memo);
        
    }

    public int BottomUp(int n, Dictionary<int,int> memo)
    {
        if(n==0)
        { 
           return 1;
        }
        if(n<0)
        {
            return 0;
        }
        

        if(memo.ContainsKey(n))
        return memo[n];

        var result= BottomUp(n-1,memo)+BottomUp(n-2,memo);
        memo[n]=result;
        return result;

    }

}