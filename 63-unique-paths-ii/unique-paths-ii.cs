public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int row=obstacleGrid.Length;
        int column=obstacleGrid[0].Length;
        if(column==1&&row==1)
        {
            return obstacleGrid[0][0]==1?0:1;
        }
        if(column==2&&row==1)
        {
            if(obstacleGrid[0][0]==1)
            return 0;
            else 
            return obstacleGrid[0][1]==0?1:0;
        }
   
       
        Dictionary<(int,int),int> memo=new();

        return DP(obstacleGrid,0,0,row,column,memo);
       

    }

    public int DP(int[][] matrix,int row,int column,int rowsize,int columnsize,Dictionary<(int,int),int> memo)
    {
      if (row >= rowsize || column >= columnsize||matrix[row][column] == 1)
        {
            return 0;
        }

        if (row == rowsize - 1 && column == columnsize - 1)
        {
          
            return 1;
        }

        if (memo.ContainsKey((row,column)))
        {
            
            return memo[(row, column)];
        }


        int rightPaths=DP(matrix, row + 1, column,  rowsize, columnsize, memo);
        int downPaths=DP(matrix, row, column + 1,  rowsize, columnsize, memo);
        memo[(row, column)] = rightPaths+downPaths;
     


        return memo[(row, column)] ;
        
        
    }
}