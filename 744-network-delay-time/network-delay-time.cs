public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
  // 1. Adjacency list
        Dictionary<int, List<(int, int)>> graph = new();
        foreach (var item in times) {
            int u = item[0], v = item[1], w = item[2];
            if (!graph.ContainsKey(u)) graph[u] = new();
            graph[u].Add((v, w));
        }
    // 2. Initialize distances
        Dictionary<int, int> weight = new();
        for (int i = 1; i <= n; i++) {
            weight[i] = int.MaxValue;
        }
        weight[k] = 0;

     // 3. Priority Queue (min-heap)
        PriorityQueue<int, int> que = new();
        que.Enqueue(k, 0);

    // 4. Dijkstra
        HashSet<int> visited = new();

    while(que.Count>0)
    {
        que.TryDequeue(out int currentnode,out int currentweight);
        if(visited.Contains(currentnode))
        continue;
        if(!graph.ContainsKey(currentnode)) //hic kenarı olmadıgı için grapha eklenmemiş olabilri
        continue;
        visited.Add(currentnode);
        
        foreach(var (child,childweight) in graph[currentnode])
        {
            if(!visited.Contains(child))
            {
                int newweight=currentweight+childweight;
                if(newweight<weight[child]) //Adan Bye 8, Adan Cye 1, C den B ye 2 olabilir. 
                {
                 que.Enqueue(child,newweight);
                weight[child]=newweight;
                }
            
                
            }
        }
    }

        // 5. Weight dictionaryde  artık en azz weightler var.
        int maxpath=0;//tüm nodelara sinyal ulasması icin en büyüğü almam laızm
        foreach(int value in weight.Values)
        {
            if(value==int.MaxValue)// bu node a k dan giden hiç bir path olmamıs demektir
            return -1;
            maxpath=Math.Max(maxpath,value);
        }
        return maxpath;

    

    
    }
}