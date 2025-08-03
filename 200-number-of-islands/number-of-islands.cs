public class Solution {
    public int NumIslands(char[][] grid) {
        int result=0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                   if(grid[i][j]=='1')
                   {
                    DFS(grid,i,j);
                    result++;
                   }

            }
         
        }
        return result;

        
    }
    public void DFS(char[][] grid,int row,int column)
    {
        int rsize=grid.Length;
        int csize=grid[0].Length;

        if(row>=rsize||row<0||column>=csize||column<0)
        return;
        if(grid[row][column]=='0'||grid[row][column]=='2')
        return;
        grid[row][column]='2';
        

        DFS(grid,row+1,column);
        DFS(grid,row-1,column);
        DFS(grid,row,column+1);
        DFS(grid,row,column-1);
    }
}