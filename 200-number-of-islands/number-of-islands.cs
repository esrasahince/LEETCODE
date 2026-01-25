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
        if(row<0||column<0||row>=grid.Length||column>=grid[0].Length||grid[row][column]=='0'||grid[row][column]=='3')
        return;
        grid[row][column]='3';

        DFS(grid,row+1,column);
        DFS(grid,row-1,column);
        DFS(grid,row,column+1);
        DFS(grid,row,column-1);
    }
}