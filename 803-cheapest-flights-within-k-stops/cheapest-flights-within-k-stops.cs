public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        Dictionary<int,List<(int,int)>> graph=new();
        for(int i=0;i<n;i++)
        {
            graph[i]=new List<(int,int)>();
        }
        foreach(var item in flights)
        {
            int from=item[0];
            int to=item[1];
            int weight=item[2];
            graph[from].Add((to,weight));
        }

        int[] distances=new int[n];
        Array.Fill(distances,int.MaxValue);
        distances[src]=0;

        //normalde n-1 kez tüm kenarların üstünden geç. Ama burda k kez
        //

        for(int i=0;i<=k;i++)
        {
          int[] temp=(int[])distances.Clone();
            for(int j=0;j<n;j++)
            {
                if(distances[j]==int.MaxValue)
                continue;
                foreach(var (item,weight) in graph[j])
                {
                    
                    int newweight=distances[j]+weight;
                    if(newweight<temp[item])
                        temp[item]=newweight;
              
                }
            }
            distances=temp;

        }
        
        return distances[dst]==int.MaxValue?-1:distances[dst];        
    }
}