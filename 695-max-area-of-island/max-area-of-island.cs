public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        if(grid==null||grid.Length==0)
        return 0;
        int row=grid.Length;
        int column=grid[0].Length;
        int result=0;
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                if(grid[i][j]==1)
                {
                    int tempresult=BFS(grid,i,j);
                    result=Math.Max(tempresult,result);

                }
            }
        }
        return result;
        
    }
    public int BFS(int[][] grid,int row,int column)
    {
        Queue<(int,int)> que=new();
        que.Enqueue((row,column));
        int result=0;
        while(que.Count>0)
        {
            var (nrow,ncolumn)=que.Dequeue();
            if(nrow<0||nrow>=grid.Length||ncolumn<0||ncolumn>=grid[0].Length||grid[nrow][ncolumn]==0)
            continue;
            result++;
            grid[nrow][ncolumn]=0;
            que.Enqueue((nrow+1,ncolumn));
            que.Enqueue((nrow-1,ncolumn));
            que.Enqueue((nrow,ncolumn+1));
            que.Enqueue((nrow,ncolumn-1));
        }

        return result;


    }
}