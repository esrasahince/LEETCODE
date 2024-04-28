public class Solution {
    public int UniquePaths(int m, int n) {
        int[,] board=new int[m,n];
        Dictionary<(int,int),int> memo=new();
       return TopDown(board,0,0,memo);
    }
    public int TopDown(int[,] board,int row, int column, Dictionary<(int,int),int> memo)
    {
        if(row==board.GetLength(0)-1&&column==board.GetLength(1)-1)
        {
            return 1;
        }
        if(row>=board.GetLength(0)||column>=board.GetLength(1))
        return 0;
        if(memo.ContainsKey((row,column)))
        {
            return memo[(row,column)];
        }

        int result=TopDown(board,row+1,column,memo)+TopDown(board,row,column+1,memo);
        memo[(row,column)]=result;
        return result;
    }
}