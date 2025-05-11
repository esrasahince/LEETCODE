public class Solution {
    public bool IsBipartite(int[][] graph) {
        int n=graph.Length;
        int[] color=new int[n]; //color are 1 and 2
        int[] visited=new int[n]; //1 visited 0 not visited
        for(int i=0;i<n;i++)
        {
            if(visited[i]==0)
            {
            if(!BFS(graph,visited,color,i))
            return false;
            }
        }
        return true;
    }
    public bool BFS(int[][] graph,int[] visited,int[] color, int i)
    {

        Queue<int> que=new();
       
        color[i]=1;
        que.Enqueue(i);
        visited[i]=1;

        while(que.Count>0)
        {
            int item=que.Dequeue();
            int colour=color[item]==1?2:1; //vice versa color 
            foreach(int neighbour in graph[item])
            {
                if(visited[neighbour]==0)
                {
                    visited[neighbour]=1;
                    color[neighbour]=colour;
                    que.Enqueue(neighbour);

                }
                else
                {
                    if(color[neighbour]==color[item])
                    {
                        return false;
                    }
                }

            }
           
        }
         return true;
        
    }
}