public class Solution {
    public int NumIslands(char[][] grid) {
        int island=0;

        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                if(grid[i][j]=='1')
                {
                    BFS(grid,i,j);
                    island++;
                }

            }
        }
        return island;
        
    }
    public void DFS(char[][] grid,int row,int column)
    {
        if(row<0||column<0||row>=grid.Length||column>=grid[0].Length)
        return;
        if(grid[row][column]=='2'||grid[row][column]=='0')
        return;
        grid[row][column]='2';
        DFS(grid,row+1,column);
        DFS(grid,row-1,column);
        DFS(grid,row,column+1);
        DFS(grid,row,column-1);
    }

     
    public void BFS(char[][] grid,int row,int column)
{
    Queue<(int,int)> que=new();
    que.Enqueue((row,column));
    grid[row][column]='2';  // Mark as visited
    
    while(que.Count>0)
    {
        var (r,c)=que.Dequeue();
        
        // Check all 4 directions
        if(r-1>=0 && grid[r-1][c]=='1') {
            grid[r-1][c]='2';  // Mark as visited when enqueuing
            que.Enqueue((r-1,c));
        }
        if(r+1<grid.Length && grid[r+1][c]=='1') {
            grid[r+1][c]='2';
            que.Enqueue((r+1,c));
        }
        if(c-1>=0 && grid[r][c-1]=='1') {
            grid[r][c-1]='2';
            que.Enqueue((r,c-1));
        }
        if(c+1<grid[0].Length && grid[r][c+1]=='1') {
            grid[r][c+1]='2';
            que.Enqueue((r,c+1));
        }
    }
}


}