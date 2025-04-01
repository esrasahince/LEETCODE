public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image==null||image.Length==0)
        return image;
        BFS(image,sr,sc,color);
        return image;
        
    }
    public void BFS(int[][] image, int nrow, int ncolumn, int color)
    {
        Queue<(int,int)> que=new();
        int i=image[nrow][ncolumn];
        que.Enqueue((nrow,ncolumn));
        HashSet<(int,int)> visited=new();
        while(que.Count>0)
        {
            var (row,column)=que.Dequeue();
            if(row<0||row>=image.Length||column<0||column>=image[0].Length||image[row][column]!=i||visited.Contains((row,column)))
            continue;
            visited.Add((row,column));
            image[row][column]=color;
            que.Enqueue((row+1,column));
            que.Enqueue((row-1,column));
            que.Enqueue((row,column+1));
            que.Enqueue((row,column-1));

        }
    }
}