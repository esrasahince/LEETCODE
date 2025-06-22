public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {

        /* ORTAK: Graf oluşturma
         * ORTAK: Distances array oluşturma*/
        Dictionary<int, List<(int, int)>> graph = new();
        int[] distance = new int[n];
        for(int i=0;i<n;i++)
        {
            graph[i] = new();
            distance[i] = int.MaxValue;
        }

        //ORTAK: distance ilk değeri değiştir
        distance[src] = 0;

        //ORTAK Graf içeriğini doldur

        foreach(var flight in flights)
        {
            int from = flight[0];
            int to = flight[1];
            int weight = flight[2];
            graph[from].Add((to, weight));
        }


        //BELMAN FORD

        for (int i = 0; i <=k; i++)
        {
            int[] temp = (int[])distance.Clone();  // okumaları distance dan yapcaz yazmaları tempe yapıcaz.

            //Her kenar için döngü baslasın
            foreach (var fl in flights) //her kenarı dolas
            {
                int from = fl[0];
                int to = fl[1];
                int weight = fl[2];

                if (distance[from] == int.MaxValue)
                    continue;
                int newweight = distance[from] + weight;
                if (newweight < temp[to])
                {
                    temp[to] = newweight;
                }
            }


            distance = temp;
        }
        return distance[dst]==int.MaxValue?-1:distance[dst];

    }}


