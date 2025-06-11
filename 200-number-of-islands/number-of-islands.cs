public class Solution {
    public int NumIslands(char[][] grid) {
        int n=grid.Length;
        int m=grid[0].Length;

        int[] parent=new int[n*m+m];
        int[] size=new int[n*m+m];
        for(int i=0;i<n*m+m;i++)
        {
            parent[i]=i;
            size[i]=1;
        }
        int onecount=0;
        int component=0;
        for(int i=0;i<grid.Length;i++)
        {
            for(int j=0;j<grid[0].Length;j++)
            {
                if(grid[i][j]=='1')
                {   onecount++;
                    int current=i*m+j;
                    int near=0;
              
                        if(j+1<m&&grid[i][j+1]=='1')
                    {
                        near=(i)*m+j+1;
                        Union(parent,size,current,near,ref component);

                    }
                          if(i+1<n&&grid[i+1][j]=='1')
                    {
                        near=(i+1)*m+j;
                        Union(parent,size,current,near,ref component);

                    }
                    
                }
            }
        }
        return onecount-component;
        
    }
    public int Find(int[] parent,int x)
    {
        if(parent[x]==x)
        return x;
        parent[x]=Find(parent,parent[x]);
        return parent[x];
    }
    public void Union(int[] parent,int[] size,int x,int y,ref int component)
    {
        int parent1=Find(parent,x);
        int parent2=Find(parent,y);
        if(parent1==parent2)
         return;
        if (size[parent1] < size[parent2]) {
            parent[parent1] = parent2;
            size[parent2] += size[parent1];
        } else {
            parent[parent2] = parent1;
            size[parent1] += size[parent2];
}

        component++;

    }
}