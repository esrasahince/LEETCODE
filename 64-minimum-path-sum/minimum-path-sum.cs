public class Solution {
    public int MinPathSum(int[][] grid) {
        
        int rownum = grid.Length - 1;
        int colnum = grid[0].Length - 1;
        for (int i = rownum; i >= 0; i--)
        {
            for (int j = colnum; j >= 0; j--)
            {
                if (i == rownum && j == colnum)
                    continue;

                if (i + 1 > rownum)
                {
                    grid[i][j] = grid[i][j] + grid[i][j + 1];
                    continue;
                }
                if(j + 1 > colnum)
                {
                    grid[i][j] = grid[i][j] + grid[i+1][j];
                    continue;
                }

                grid[i][j] = grid[i][j] + Math.Min(grid[i+1][j], grid[i][j+1]); 
            }
        }
        return grid[0][0];

        
    }
}