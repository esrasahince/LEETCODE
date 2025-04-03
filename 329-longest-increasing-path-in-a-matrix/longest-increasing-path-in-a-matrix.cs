public class Solution {
    public int LongestIncreasingPath(int[][] matrix) {
        if(matrix==null||matrix.Length==0)
        return 0;

        int row=matrix.Length;
        int column=matrix[0].Length;

        int[,] visited=new int[row,column];
        int maxlen=0;
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                maxlen=Math.Max(maxlen,DFS(matrix,i,j,visited,-1));
            }
        }  
        return maxlen;      
    }

    public int DFS(int[][] matrix,int row,int column,int[,] visited,int last)
    {
    
        if(row<0||row>=matrix.Length||column<0||column>=matrix[0].Length||matrix[row][column]<=last)
        return 0;
        if(visited[row,column]!=0)
        return visited[row,column];
        

        visited[row,column]=Math.Max(visited[row,column],DFS(matrix,row+1,column,visited, matrix[row][column])+1);
        visited[row,column]=Math.Max(visited[row,column],DFS(matrix,row-1,column,visited, matrix[row][column])+1);
        visited[row,column]=Math.Max(visited[row,column],DFS(matrix,row,column+1,visited, matrix[row][column])+1);
        visited[row,column]=Math.Max(visited[row,column],DFS(matrix,row,column-1,visited, matrix[row][column])+1);
        return  visited[row,column];



    }

}