using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        int n = graph.Length;
        List<int> result=new();
        int[] visited = new int[n]; // 0: Unvisited, 1: Visiting, 2: Visited

        for (int i = 0; i < n; i++)
        {
            if (DFS(i, graph, visited))
            {
                result.Add(i);
            }
        }

    
        

        return result;
    }

    private bool DFS(int u, int[][] graph, int[] visited)
    {
       
        visited[u] = 1;

        foreach (int v in graph[u])
        {
            // Döngü tespit edildi
            if (visited[v] == 1)
            {
                return false;
            }
            // Ziyaret edilmemiş komşuyu ziyaret et
            if (visited[v] == 0)
            {
                if (!DFS(v, graph, visited))
                {
                    return false;
                }
            }
        }

        // Tüm komşular güvenli veya zaten ziyaret edilmişse, bu düğüm de güvenlidir
        visited[u] = 2;
        return true;
    }
}