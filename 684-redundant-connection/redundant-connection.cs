public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        //node sayısı n ise ağaçta n-1 kenar olmalı
        //buradaki kenar sayısı n ise 1 tane kenar,
        //n+1 ise iki tane kenar fazladan demektir
        //eger birden fazla ise son inputu donmemizi istiyor

        //UNION FIND
        //Once kac tane node'umuz oldugunu bulalım.
        HashSet<int> uniquenode=new();
        foreach(var edge in edges)
        {
            uniquenode.Add(edge[0]);
            uniquenode.Add(edge[1]);
            
        }
        int n=uniquenode.Count;

        //şimde her node bagımsız gibi düşünüp her nodeun parentını tutacagımız
        //diziyi tanımlıyoruz

        int[] parent=new int[n+1];

        //başta hepsi bağımsız yani her nodeun parentı kendi gibi yapıyoruz

        for(int i=1;i<n+1;i++)
        {
            parent[i]=i; //yani 1. node parentı 1, 2. node parentı 2
        }

        //iki nodeun parentı farklı ise birleştir
        //parentlar aynı ise cycle var demektir
        int[] result=new int[2];

        foreach(var edge in edges)
        {
            int first=edge[0];
            int second=edge[1];

            int firstparent=Find(first,parent);
            int secondparent=Find(second,parent);
            if(firstparent==secondparent)
            {
                result[0]=first;
                result[1]=second;
                //THERE IS CYLE
            }
            else
            {//DIKKAT UNION PARENTLAR UZERINDEN YAPILIR
                Union(firstparent,secondparent,parent);
            }
        }
        return result;
        
    }
    private int Find(int x, int[] parent) {
        if (parent[x]== x)
        return x; 
        return Find(parent[x], parent); // path compression
        
       
    }

    private void Union(int x, int y, int[] parent) {
        parent[x] = y; // x'in kökünü y'nin köküne bağla
    }
}