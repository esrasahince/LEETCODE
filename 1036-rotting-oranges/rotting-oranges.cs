public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<(int,int,int)> que=new();
        int result=0;
        int fresh=0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                if(grid[i][j]==2)
                {
                
                  que.Enqueue((i,j,0));
                  grid[i][j]=3;

                }
                 if(grid[i][j]==1)
                 fresh++;
                
            }
        }
        
        while(que.Count>0)
        {
            var (r,c,time)=que.Dequeue();
            result = Math.Max(result, time);
            if(r+1<grid.Length&&grid[r+1][c]==1)
            {
                que.Enqueue((r+1,c,time+1));
                grid[r+1][c]=3;
                fresh--;
            }
               if(c+1<grid[0].Length&&grid[r][c+1]==1)
            {
                que.Enqueue((r,c+1,time+1));
                grid[r][c+1]=3;
                 fresh--;
            }
               if(r-1>=0&&grid[r-1][c]==1)
            {
                que.Enqueue((r-1,c,time+1));
                grid[r-1][c]=3;
                 fresh--;
            }
               if(c-1>=0&&grid[r][c-1]==1)
            {
                que.Enqueue((r,c-1,time+1));
                grid[r][c-1]=3;
                 fresh--;
            }
        }
        return fresh==0?result:-1;
    }
}