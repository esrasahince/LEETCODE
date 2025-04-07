public class Solution {
    public int UniquePaths(int m, int n) {
        return BottomUp(m,n);
        
    }
    public int BottomUp(int row,int column)
    {
        int[,] grid=new int[row,column];
        grid[row-1,column-1]=1;
      

        for(int i=row-1;i>=0;i--)
        {
            for(int j=column-1;j>=0;j--)
            {
                if(i==row-1&&j==column-1)
                {
                grid[row-1,column-1]=1;
                continue;
                }
                int right=0;
                int down=0;
                if(j+1<=column-1)
                {
                  right=grid[i,j+1];
                }
                   if(i+1<=row-1)
                {
                  down=grid[i+1,j];
                }
                grid[i,j]=down+right;
            }
        }
        return grid[0,0];
    }
}