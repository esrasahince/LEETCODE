public class Solution {

   public int LastStoneWeightII(int[] stones) {
   int totalsum=0;
   int n=stones.Length;
   
   for(int i=0;i<n;i++)
   {
   totalsum+=stones[i];
   }
   
   //goal 
   int sum=totalsum/2;
   bool[,] dp=new bool[n+1,sum+1];
   
   //sum 0 iken stones dizisindeki eleman sayısı ne olursa olsun toplamı 0 olan subset oluşturabiliri.
   //Dikkat stoneslardan biri 0 olsaydı bu mantık boyle işlemezdi
   for(int i=0;i<n+1;i++)
   {
   dp[i,0]=true;
   }
   for(int i=1;i<n+1;i++)
   {
     for(int j=1;j<sum+1;j++)
     {
        if(stones[i-1]>j) //dont include
        { 
         dp[i,j]=dp[i-1,j];
        }
        else
        {
        dp[i,j]=dp[i-1,j]||dp[i-1,j-stones[i-1]];
        }
     }
   }
   
   //amacımız s1 in aslında totalsumın yarısına en yakın halini bulmak
   //yani yukarıdaki tabloda dp tablosunun en alttaki satırında j= totalsum/2 ye en yakın true değeri bize 
   //s1 sum alacağı maxımumu verir.
   int s1sum=0;
   for(int i=0;i<=sum;i++) 
   { 
   if(dp[n,i])
        s1sum=i;
   
   }
   
   return Math.Abs(totalsum-(2*s1sum));
   }}