public class Solution {
    public int MinCostConnectPoints(int[][] points) {

        PriorityQueue<(int,int),int> que=new();
        HashSet<(int,int)> visited=new();
        que.Enqueue((points[0][0],points[0][1]),0);
     
        int totalcost=0;

        while(que.Count>0)
        {
             que.TryDequeue(out var node,out var dist);
             if(visited.Contains((node.Item1, node.Item2)))
                continue;

             visited.Add((node.Item1,node.Item2));
             totalcost+=dist;
            foreach(var item in points)
            {
                if(!visited.Contains((item[0],item[1])))
                {
                    int newdist=CalculateManhattan(node.Item1,item[0],node.Item2,item[1]);
                    que.Enqueue((item[0],item[1]),newdist);

                }
            }
            
        }
        return totalcost;
      
        
    }
    public int CalculateManhattan(int x1,int x2,int y1,int y2)
    {
        return Math.Abs(x1-x2)+Math.Abs(y1-y2);
    }
}