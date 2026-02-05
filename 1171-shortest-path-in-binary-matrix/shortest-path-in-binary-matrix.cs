public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        if(grid[0][0]!=0||grid[grid.Length-1][grid[0].Length-1]!=0)
        return -1;
        return BFS(grid);

        
    }
    public int BFS(int[][] grid)    
    {

        Queue<(int,int,int)> que=new();
        que.Enqueue((0,0,1));
        grid[0][0]=2;
        List<(int,int)> directions=new(){(0,1),(1,0),(-1,0),(0,-1),(1,1),(-1,-1),(-1,1),(1,-1)};
        while(que.Count>0)
        {
            var (row,column,distance)=que.Dequeue();
            if(row==grid.Length-1&&column==grid[0].Length-1)
            return distance;
            
            foreach(var item in directions)
            {
                int newrow=row+item.Item1;
                int newcolumn=column+item.Item2;
                if(newrow<0||newrow>=grid.Length||newcolumn<0||newcolumn>=grid[0].Length||grid[newrow][newcolumn]==1||grid[newrow][newcolumn]==2)
                continue;
                que.Enqueue((newrow,newcolumn,distance+1));
                grid[newrow][newcolumn]=2;

            }
        }
        return -1;


    }
}