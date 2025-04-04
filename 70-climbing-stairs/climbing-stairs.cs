
   
       public class Solution {
    public int ClimbStairs(int n) {
        Dictionary<int,int> memo=new();
        return Recursive(n,0,memo);

        
    }

    public int Recursive(int n, int index,Dictionary<int,int> memo)
    {
        if(memo.ContainsKey(index))
        return memo[index];
        if(index>n)
        return 0;
        if(memo.ContainsKey(index))
        return memo[index];
        if(index==n)
        return 1;
        
        
    
         int one=Recursive(n,index+1,memo);
         int two=Recursive(n,index+2,memo);
         memo[index]=one+two;

        return one+two;
    }
}
        
    
         