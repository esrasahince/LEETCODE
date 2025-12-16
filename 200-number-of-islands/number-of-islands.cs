public class Solution {
    public int NumIslands(char[][] grid) {

        HashSet<(int,int)> visited=new();
        int result=0;

        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                if(visited.Contains((i,j))||grid[i][j]=='0')
                continue;
                DFS(grid,i,j,visited);
                result++;
            }
        }
        return result;
        
        
    }

    public void DFS(char[][] grid,int row,int column,HashSet<(int,int)> visited)
    {
        if(row>=grid.Length||column>=grid[0].Length||row<0||column<0)
        return;
        if(visited.Contains((row,column)))
        return;
        if(grid[row][column]=='0')
        return;

        
        visited.Add((row,column));

        DFS(grid,row+1,column,visited);
        DFS(grid,row-1,column,visited);
        DFS(grid,row,column+1,visited);
        DFS(grid,row,column-1,visited);
    }

}