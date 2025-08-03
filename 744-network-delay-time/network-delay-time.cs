public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        int[] distances=new int[n+1];
       int result=0;
        Dictionary<int,List<(int,int)>> graph=new();
        for(int i=0;i<=n;i++)
        {
            distances[i]=int.MaxValue;
            graph[i]=new List<(int,int)>();
        }
        distances[k]=0;
        foreach(var time in times)
        {
            int from=time[0];
            int to=time[1];
            int weight=time[2];
            graph[from].Add((to,weight));
        }
        PriorityQueue<int,int> que=new();
        que.Enqueue(k,0);
        while(que.Count>0)
        {
            que.TryDequeue( out int current,out int currentdist);
            if(distances[current]<currentdist)
            continue;
            foreach((int ngb,int weight) in graph[current])
            {
                if(weight+currentdist<distances[ngb])
                {
                    distances[ngb]=weight+currentdist;
                      que.Enqueue(ngb,distances[ngb]);
                    
                }
              

            }

        }
   for (int i = 1; i <= n; i++) {
    if (distances[i] == int.MaxValue)
        return -1;
    result = Math.Max(result, distances[i]);
}
return result;

     
        
    }
}