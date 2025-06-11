public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        //ADJACENCY LIST CREATE
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
        //START POINT IS DETERMINED
        HashSet<int> visited=new();
        return DFS(graph,source,destination,visited);


    }
    public bool DFS(Dictionary<int,List<int>> graph,int current,int end,HashSet<int> visited)
    {
        if(current==null)
        return false;

        if(current==end)
        return true;

        visited.Add(current);
        foreach(int child in graph[current])
        {
            if(!visited.Contains(child))
            {
                if(DFS(graph,child,end,visited))
                return true;
            }
        }
        return false;
    }
}