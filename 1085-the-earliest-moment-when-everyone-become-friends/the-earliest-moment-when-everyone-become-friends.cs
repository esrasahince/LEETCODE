public class Solution
{
    

    public int EarliestAcq(int[][] logs, int n)
    {
        Array.Sort(logs,(a, b) => a[0].CompareTo(b[0]));
        int[] parent = new int[n];
        int[] rank = new int[n];
        for (int i = 0; i < n; i++)
        {
            parent[i] = i;

        }
        int component = n;
        foreach (var item in logs)
        {
            if (Union(parent, rank, item[1], item[2]))
                component--;
            if (component == 1)
                return item[0];
        }

        return -1;

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
        if (xparent == yparent)
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