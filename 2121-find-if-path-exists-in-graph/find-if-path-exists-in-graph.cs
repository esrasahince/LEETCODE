public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        Dictionary<int,List<int>> graph=new();
        for(int i=0;i<n;i++)
        {
            graph[i]=new List<int>();
        }
        foreach(var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        HashSet<int> visited=new();
        return DFS(graph,source,destination,visited);
        //undirected graph
        
    }
    public bool DFS(Dictionary<int,List<int>> graph, int current,int dest,HashSet<int> visited)
    {
        if(current==dest)
        return true;
        if(visited.Contains(current))
        return false;
        visited.Add(current);
        foreach(int i in graph[current])
        {
            if(!visited.Contains(i))
            {
                if(DFS(graph,i,dest,visited))
                return true;
            }
        }
        return false;
    }
}