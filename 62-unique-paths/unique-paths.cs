public class Solution {
    public int UniquePaths(int m, int n) {
        Dictionary<(int,int),int> memo=new();

        return DP(m,n,0,0,memo);
        
    }

    public int DP(int m,int n,int row,int column,Dictionary<(int,int),int> memo)
    {

        if(row>=m||column>=n)
        return 0;
        if(row==m-1&&column==n-1)
        return 1;
        if(memo.ContainsKey((row,column)))
        return memo[(row,column)];

        int right=DP(m,n,row,column+1,memo);
        int down=DP(m,n,row+1,column,memo);
        memo[(row,column)]= right+down;
        return memo[(row,column)];
    }
}