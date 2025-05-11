public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n=isConnected.Length;
        int[] parent=new int[n+1];
        int[] size=new int[n+1];
        int count=n;
        for(int i=1;i<n+1;i++)
        {
            size[i]=1;
            parent[i]=i;
        }
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(i!=j&&isConnected[i][j]==1)
                {
                    int u=i;
                    int v=j;
                    Union(u,v,parent,size,ref count);
                }
            }
        }
        return count;
    }
    public void Union(int first,int second,int[] parent,int[] size, ref int count)
    {
        int firstparent=Find(first,parent);
        int secondparent=Find(second,parent);
        if(firstparent==secondparent)
        return;
        if(size[firstparent]<size[secondparent])
        {
            parent[firstparent]=secondparent;
            size[secondparent]+=size[firstparent];
            
        }
        else{
         parent[secondparent]=firstparent;
            size[firstparent]+=size[secondparent];
        }
        count--;
    }
    public int Find(int x, int[] parent)
    {
        if(x!=parent[x])
        parent[x]=Find(parent[x],parent);
        return parent[x];
    }
}