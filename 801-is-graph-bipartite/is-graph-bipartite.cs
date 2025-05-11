public class Solution {
    public bool IsBipartite(int[][] graph) {
        int n=graph.Length;
        int[] color=new int[n]; //color are 1 and 2
     
        for(int i=0;i<n;i++)
        {
            if(color[i]==0)
            {
            if(!BFS(graph,color,i))
            return false;
            }
        }
        return true;
    }
    public bool BFS(int[][] graph,int[] color, int i)
    {

        Queue<int> que=new();
       
        color[i]=1;
        que.Enqueue(i);
   

        while(que.Count>0)
        {
            int item=que.Dequeue();
            int nextcolour=color[item]==1?2:1; //vice versa color 
            foreach(int neighbour in graph[item])
            {
                if(color[neighbour]==0)
                {
                    
                    color[neighbour]=nextcolour;
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