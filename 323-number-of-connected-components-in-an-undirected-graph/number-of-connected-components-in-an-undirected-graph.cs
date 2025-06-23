public class Solution
{
    public int CountComponents(int n, int[][] edges)
    {
        int[] parent = new int[n];
        int[] rank = new int[n];
        for (int i = 0; i < n; i++)
        {
            parent[i] = i;
        }
        int component = n;
        foreach (var edge in edges)
        {
            if (Union(parent, rank, edge[0], edge[1]))
                component--;
        }
        return component;

    }
    public int Find(int x, int[] parent)
    {
        if (x != parent[x])
            parent[x] = Find(parent[x], parent);
        return parent[x];
    }
    public bool Union(int[] parent, int[] rank, int x, int y)
    {
        int xparent = Find(x,parent);
        int yparent = Find(y,parent);
        if ( xparent== yparent)
            return false;
        if (rank[xparent] < rank[yparent])
        {
            parent[xparent] = yparent;
        }
        else if (rank[xparent] > rank[yparent])
        {
            parent[yparent] = xparent;
        }
        else
        {
            parent[yparent] = xparent;
            rank[xparent]++;
        }
        return true;
    }
}