public class Solution {
    public int UniquePaths(int m, int n) {
        Dictionary<(int,int),int> memo=new();
        return DFS(m,n,0,0,memo);
    }
    public int DFS(int row,int column,int crow,int ccolumn,Dictionary<(int,int),int> memo)
    {
        if(crow>=row||ccolumn>=column)
        return 0;
        if(crow==row-1&&ccolumn==column-1)
        return 1;
        if(memo.ContainsKey((crow,ccolumn)))
        return memo[(crow,ccolumn)];
        int result=DFS(row,column,crow+1,ccolumn,memo)+DFS(row,column,crow,ccolumn+1,memo);
        memo[(crow,ccolumn)]=result;
        return result;
    }
}