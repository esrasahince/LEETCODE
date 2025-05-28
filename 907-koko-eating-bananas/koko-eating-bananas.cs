 public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
      //minimum hız 1 olabilir
      //maximum hız sonsuz olabilir ama buna gerek yok
      //biz minimum bulmaya calısıyoruz. Maximumu dizideki max eleman olarak alsak yeterli
      //özetle [1.....maxitem] şeklinde bi dizi oluşturuyoruz. Bu dizi ne anlama geliyor
      //bu aslında bizim hızlarımız. minimum hızı bulmaya çalışıyoruz.
      //normalde tek tek tüm elemanları deneyerek O(n) zamanda bulabiliriz. Ama binary search burda işimize yarar
      Array.Sort(piles);

      int left=1;
      int right=piles[piles.Length-1]; //max eleman

      while(left<=right)
      {
        int middle=left+(right-left)/2;

        //F-F-F-T-T-T-T-T
     
        if(TotalTime(piles,middle,h)) //daha kucuk rakamlarda da true gelebilir mi acaba 
        {
            right=middle-1;
        }
        else
        {
            left=middle+1;
        }

      }
      return left;
        
        
    }
     public bool TotalTime(int[] piles,int speed,int target)
    {
        long sum=0;
        foreach(int item in piles)
        {
           sum+=(long)Math.Ceiling((double)item / speed); 
        }
       if(sum>target)
       {
        return false;
       }
       return true;
       
    }
}
 