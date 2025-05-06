public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        //Valid Tree
        //1.edge must be equal to n-1
        //2. all nodes must be visted
        //no cycle

        if(edges.Length!=n-1)
        return false;
        //CREATE GRAPH ADJACENCY LIST
        Dictionary<int,List<int>> graph=new();
        for(int i=0;i<n;i++)
        {
            graph[i]=new List<int>();
        }
        //FİLL IT
        foreach(var item in edges)
        {
            graph[item[0]].Add(item[1]);
            graph[item[1]].Add(item[0]);
        }
        //CYCLE DETECTION AND TRAVERSAL
        HashSet<int> visited=new();
        if(BFS(graph,visited,0,-1))
        return false;
        if(visited.Count!=n)
        return false;

        return true;
        
    }
    public bool BFS(Dictionary<int,List<int>> graph,HashSet<int> visited, int current,int parent)
    {
        Queue<(int,int)> que=new();
        que.Enqueue((current,parent));
        visited.Add(current);
        while(que.Count>0)
        {
            (int cnode,int cparent)=que.Dequeue();
            foreach(int child in graph[cnode])
            {
                if(child==cparent)
                continue;
                if(visited.Contains(child))
                return true;
                que.Enqueue((child,cnode));
                visited.Add(child);
            }
        }
        return false;
    }
}