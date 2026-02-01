public class Solution 
{
    public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges) 
    {
        // Edge'lere orijinal index ekle
        int[][] indexedEdges = new int[edges.Length][];
        for (int i = 0; i < edges.Length; i++)
        {
            indexedEdges[i] = new int[] 
            { 
                edges[i][0],  // from
                edges[i][1],  // to
                edges[i][2],  // cost
                i             // original index
            };
        }
        
        // Edge'leri maliyete göre sırala
        Array.Sort(indexedEdges, (a, b) => a[2].CompareTo(b[2]));
        
        // Result listeleri
        List<IList<int>> result = new();
        result.Add(new List<int>());  // Critical
        result.Add(new List<int>());  // Pseudo-critical
        
        // Orijinal MST maliyeti
        int originalCost = Kruskal(n, indexedEdges, -1, -1);
        
        // Her edge'i test et
        for(int i = 0; i < edges.Length; i++)
        {
            // TEST 1: Edge'i HARIÇ TUT
            int costWithout = Kruskal(n, indexedEdges, i, -1);
            
            if(costWithout > originalCost)
            {
                // Critical edge
                result[0].Add(i);  // ✅ Edge index'ini ekle
            }
            else
            {
                // TEST 2: Edge'i ZORLA EKLE
                int costWith = Kruskal(n, indexedEdges, -1, i);
                
                if(costWith == originalCost)
                {
                    // Pseudo-critical edge
                    result[1].Add(i);  // ✅ Edge index'ini ekle
                }
            }
        }
        
        return result;
    }

    // skipIndex: Bu edge index'ini atla
    // forceIndex: Bu edge index'ini zorla ekle
    public int Kruskal(int n, int[][] edges, int skipIndex, int forceIndex)
    {
        int totalCost = 0;
        int[] parent = new int[n];
        int[] rank = new int[n];
        int totalEdge = 0;
        
        for(int i = 0; i < n; i++)
        {
            parent[i] = i;
            rank[i] = 0;
        }
        
        // ✅ ÖNCE forceIndex'i ekle (varsa)
        if(forceIndex != -1)
        {
            foreach(var edge in edges)
            {
                if(edge[3] == forceIndex)  // Orijinal index'i bul
                {
                    int parentX = Find(parent, edge[0]);
                    int parentY = Find(parent, edge[1]);
                    
                    if(parentX != parentY)
                    {
                        Union(parentX, parentY, parent, rank);
                        totalCost += edge[2];
                        totalEdge++;
                    }
                    break;
                }
            }
        }
        
        // Normal Kruskal
        foreach(var edge in edges)
        {
            // skipIndex ise atla
            if(edge[3] == skipIndex)
                continue;
            
            int parentX = Find(parent, edge[0]);
            int parentY = Find(parent, edge[1]);
            
            if(parentX != parentY)
            {
                Union(parentX, parentY, parent, rank);
                totalEdge++;
                totalCost += edge[2];
            }
            
            if(totalEdge == n - 1) 
                break;
        }

        // MST tamamlanmadıysa sonsuz döndür
        return totalEdge == n - 1 ? totalCost : int.MaxValue;
    }

    public int Find(int[] parent, int x)
    {
        if(x != parent[x])
        {
            parent[x] = Find(parent, parent[x]);
        }
        return parent[x];
    }
    
    public void Union(int parentX, int parentY, int[] parent, int[] rank)
    {
        if(rank[parentX] > rank[parentY])
        {
            parent[parentY] = parentX;
        }
        else if(rank[parentY] > rank[parentX])
        {
            parent[parentX] = parentY;
        }
        else
        {
            parent[parentY] = parentX;
            rank[parentX]++;
        }
    }
}