public class Solution {
    public int NumIslands(char[][] grid) {
    int result=0;
    for(int i=0;i<grid.Length;i++)
    {
        for(int j=0;j<grid[0].Length;j++)
        {
            //yeni bir ada bulduğunda tüm adayı işaretlemeye geçiceksin.
            //bu nedenle resultı burda artırman lazım.
            if(grid[i][j]=='1')
            {
            result++;
            GraphTraversal(grid,i,j);
            }

        }
    }
   
      return result;
        
    }

   public void GraphTraversal(char[][] grid,int row, int column)
   {
    if(row>=grid.Length||column>=grid[0].Length||row==-1||column==-1)
    return;
    if(grid[row][column]!='1')
    return;
    //2 means visited.

    grid[row][column]='2';
  

    GraphTraversal(grid,row+1,column);
    GraphTraversal(grid,row-1,column);
    GraphTraversal(grid,row,column+1);
    GraphTraversal(grid,row,column-1);
    



    
   }
}