public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
 if(n==1)
 return true;
        Dictionary<int,List<int>> graph=new();
        Dictionary<int,bool> visited=new();
        for(int i=0;i<n;i++)
        {
            graph[i]=new List<int>();
            visited[i]=false;
        }
        foreach(var item in edges)
        {
            graph[item[0]].Add(item[1]);
            graph[item[1]].Add(item[0]);
        }

        //BFS

       Queue<int> queue=new();
       queue.Enqueue(source);
       visited[source]=true;
       while(queue.Count>0)
       {
        int node=queue.Dequeue();
        foreach(int child in graph[node])
        {
            if(child==destination)
            return true;
            if(visited[child]==false)
            {
            queue.Enqueue(child);
            visited[child]=true;
            }
        }
       }
       return false;

    }
}