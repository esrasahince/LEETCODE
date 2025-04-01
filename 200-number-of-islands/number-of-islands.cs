public class Solution {
    
    public int NumIslands(char[][] grid) {

        if(grid.Length==0)
        return 0;
        int row=grid.Length;
        int column=grid[0].Length;
        int count=0;


        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                if(grid[i][j]=='1')
                {
                   
                    count++;
                    DFS(grid,i,j);

                }
            }
        }
        return count;        
    }
    public void DFS(char[][] grid,int row,int column)
    {
        if(row>=grid.Length||row<0||column<0||column>=grid[0].Length||grid[row][column]=='2'||grid[row][column]=='0')
        return;
        grid[row][column]='2';
        DFS(grid,row-1,column);
        DFS(grid,row+1,column);
        DFS(grid,row,column-1);
        DFS(grid,row,column+1);
    }
}