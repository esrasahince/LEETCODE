public class Solution {
    public bool ValidTree(int n, int[][] edges) {
   //Ağaçta kenar sayısı node sayısından bir eksik olmalı
        if(edges.Length!=n-1)
        return false;

    //Adjacency List create

        Dictionary<int,List<int>> graph=new();
        for(int i=0;i<n;i++)
        {
            graph[i]=new List<int>();

        }
        //Adjacency List fill

        foreach(var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }


    //DFS and CYCLE DETECTION     
        HashSet<int> visited=new(); 
        if(Traversal(graph,visited,0,-1))
            return false;
        if(visited.Count!=n)
        return false;

            return true;
    }
    public bool Traversal( Dictionary<int,List<int>> graph,   HashSet<int> visited,int current,int parent)
    {
        visited.Add(current);

        foreach(int child in graph[current])
        {
            if(child==parent)
            continue;
            if(!visited.Contains(child))
            {
                if(Traversal(graph,visited,child,current))
                return true;
            }
            else
            {
                return true;
            }
            //visited listesinde var fakat
           
        }
        return false;
    }
    
}