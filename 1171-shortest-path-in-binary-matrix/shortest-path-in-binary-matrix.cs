public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
         int n=grid.Length-1;
        if(grid[0][0]==1||grid[n][n]==1)
        return -1;
        Queue<(int,int,int)> que=new();
        que.Enqueue((0,0,1));
         grid[0][0]=2;
        int result=int.MaxValue;
        int[][] direction=new int[8][]{
            [-1,-1],
            [-1,0],
            [-1,1],
            [1,0],
            [1,1],
            [1,-1],
            [0,-1],
            [0,1]};
       
        while(que.Count>0)
        {
            var(row,column,dist)=que.Dequeue();
            if(row==n&&column==n)
            {
                result=Math.Min(result,dist);
            }
            for(int i=0;i<direction.Length;i++)
            {
                int r=row+direction[i][0];
                int c=column+direction[i][1];
                if(r>=0&&r<=n&&c>=0&&c<=n&&grid[r][c]==0)
                {
                    que.Enqueue((r,c,dist+1));
                    grid[r][c]=2;
                }
            }
        }
          
        
        return result==int.MaxValue?-1:result;
        
    }
}