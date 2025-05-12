
public class Solution {
    public int ClimbStairs(int n) {
        if(n<=0)
        return 0;

        Dictionary<int,int> memo=new();
        return TopDown(0,memo,n);
        

    }

    public int TopDown(int ind, Dictionary<int,int> memo, int n)
    {

        if(ind>n)
        return 0;
        if(ind==n)
        return 1;
        if(memo.ContainsKey(ind))
        return memo[ind];

         int result=TopDown(ind+1,memo,n)+TopDown(ind+2,memo,n);
         memo[ind]=result;
         return result;

        
    }}