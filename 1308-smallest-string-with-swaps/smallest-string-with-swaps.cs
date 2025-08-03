public class Solution {
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs) {
        int n=s.Length;
        int[] parent=new int[n];
        int[] size=new int[n];
        Dictionary<int,List<int>> dict=new();
        for(int i=0;i<n;i++)
        {
            parent[i]=i;
            dict[i]=new List<int>();
            size[i]=1;
        }
        foreach(var pair in pairs)
        {
            Union(pair[0],pair[1],parent,size);
        }
        for(int i=0;i<n;i++)
        {
            int root=Find(i,parent);
            dict[root].Add(i);
            
        }
   List<List<char>> res = new();
char[] result = s.ToCharArray(); // Sonucu saklayacağın array

foreach (var list in dict)
{
    if (list.Value.Count == 0)
        continue;

    List<int> indices = list.Value;
    List<char> charlist = new();

    foreach (int i in indices)
        charlist.Add(s[i]);

    // Hem karakterleri hem indexleri sırala
    charlist.Sort();
    indices.Sort();

    for (int i = 0; i < indices.Count; i++)
        result[indices[i]] = charlist[i];
}
return new String(result);
       
        
    }
    public int Find(int x, int[] parent)
    {
        if(parent[x]!=x)
        {
            parent[x]=Find(parent[x],parent);
        }
        return parent[x];
    }
    public void Union(int x,int y, int[] parent,int[] size)
    {
        int rootx=Find(x,parent);
        int rooty=Find(y,parent);
        if(rootx==rooty)
        return;
        if(size[rootx]<=size[rooty])
        {
            parent[rootx]=rooty;
            size[rooty]+=size[rootx];
        }
        else
        {
              parent[rooty]=rootx;
            size[rootx]+=size[rooty];

        }
    }
}