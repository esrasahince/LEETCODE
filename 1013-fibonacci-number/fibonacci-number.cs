public class Solution {
    public int Fib(int n) {

       
       Dictionary<int,int> memo=new();
       memo[0]=0;
       memo[1]=1;
       return DynamicProgramming(n,memo);

    }
    public int DynamicProgramming(int n, Dictionary<int,int> memo)
    {
        if(memo.Keys.Contains(n))
        return memo[n];
        else{
             int result=DynamicProgramming(n-1,memo)+DynamicProgramming(n-2,memo);
             memo[n]=result;
             return result;
        }
    }

   

    
}