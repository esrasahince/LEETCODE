public class Solution {
    public bool CanFinish(int n, int[][] prerequisites) {

        Dictionary<int,List<int>> graph=new();
        Dictionary<int,int> incoming=new();
        for(int i=0;i<n;i++)
        {
            graph[i]=new List<int>();
            incoming[i]=0;
        }
         for(int i=0;i<prerequisites.Length;i++)
        {
            int from=prerequisites[i][1];
            int to=prerequisites[i][0];
            graph[from].Add(to);
            incoming[to]++;
        }

        Queue<int> que=new();
        foreach(var item in incoming)
        {
            if(item.Value==0)
            que.Enqueue(item.Key);

        }
        int visited=0;

        while(que.Count>0)
        {
            int item=que.Dequeue();
            visited++;
            List<int> relateditems=graph[item];
            foreach(int node in relateditems)
            {
                incoming[node]--;
                if(incoming[node]==0)
                que.Enqueue(node);
            }


        }
        return visited==n?true:false;
       
        
    }
}