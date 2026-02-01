public class Solution {
    public int MinCostConnectPoints(int[][] points) {

        PriorityQueue<int,int> que=new(); //elemanın indexi ve distanceı
        HashSet<int> visited=new();
        que.Enqueue(0,0); //0. indexdeki elemanı 0 costla ekleriz. 
     
        int totalcost=0;

        while(que.Count>0)
        {
             que.TryDequeue(out int index,out int dist);
             if(visited.Contains(index))
                continue;

             visited.Add(index);
             totalcost+=dist;
            for(int i=0;i<points.Length;i++)
            {
                if(!visited.Contains(i))
                {
                    int newdist=CalculateManhattan(points[i][0],points[index][0],points[i][1],points[index][1]);
                    que.Enqueue(i,newdist);

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