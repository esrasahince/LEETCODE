public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {

        //adjancecy List
        Dictionary<int,List<List<int>>>graph=new();

        //distances 
        int[] distance=new int[n+1];
        for(int i=1;i<=n;i++)
        {
            graph[i]=new();
            distance[i]=int.MaxValue;
        }
        distance[k]=0;
        foreach(var item in times)
        {
            int from=item[0];
            int to=item[1];
            int weight=item[2];
            graph[from].Add(new List<int>(){to,weight});
        }


        PriorityQueue<int,int> que=new();
        que.Enqueue(k,0);
        while(que.Count>0)
        {
            que.TryDequeue(out int node,out int currentweight);

            foreach(var itemarr in graph[node])
            {
                int child=itemarr[0];
                int childdist=itemarr[1];

                //child node a gidicem maliyetim ne olur
                //currentweight+childdist
                //peki buraya daha onceden daha az maliyetle gelmiş miydim cevap distance[child]

                if(currentweight+childdist<distance[child])
                {
                    distance[child]=currentweight+childdist;
                    que.Enqueue(child,distance[child]);
                }
                //else daha maliyetliyse buraya gelmem. 

            }
        }
      int result=int.MinValue;
      for(int i=1;i<=n;i++)
      {
        if(i==k) continue;
        if(distance[i]==int.MaxValue)
        return -1;
        result=Math.Max(result,distance[i]);
      }
return result;
        
    }
}