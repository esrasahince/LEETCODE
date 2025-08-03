public class Solution {
    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges) {

        Dictionary<int,List<(char,int)>> graph=new();
        for(int i=0;i<n;i++)
        {
            if(!graph.ContainsKey(i))
            {
                graph[i]=new List<(char,int)>();
            }
        }
        foreach(var item in redEdges)
        {
            graph[item[0]].Add(('R',item[1]));
        }
            foreach(var item in blueEdges)
        {
            graph[item[0]].Add(('B',item[1]));
        }

        int[] distances=new int[n];
        Queue<(int,int,char)> que=new();
        que.Enqueue((0,0,'B'));
        que.Enqueue((0,0,'R'));
        HashSet<(int,char)> visited=new();
        visited.Add((0,'R'));
        visited.Add((0,'B'));
        while(que.Count>0)
        {
            (int current,int dist,char color)=que.Dequeue();
           if(current!=0&&distances[current] ==0 || distances[current] > dist)
            {
                distances[current] = dist;
            }
            char nextcolor=color=='R'?'B':'R';

            foreach( (char ngbcolor,int ngbindex) in graph[current])
            { 
                if(!visited.Contains((ngbindex,ngbcolor))&&ngbcolor==nextcolor)
                {
                   
                        que.Enqueue((ngbindex,dist+1,ngbcolor));
                        visited.Add((ngbindex,ngbcolor));
                    
                }
              

            }
        }
        for(int i=1;i<distances.Length;i++)
        {
            if(distances[i]==0)
            distances[i]=-1;
        }
        return distances;



        
    }
}