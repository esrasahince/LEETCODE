public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
         if (flowerbed.Length == 1) {
            if (flowerbed[0] == 0) {
                return n <= 1;
            } else {
                return n == 0;
            }
        }
         
         int before=0;
         int next=0;

        for(int i=0;i<flowerbed.Length;i++)
        {
          
          if(i==flowerbed.Length-1)
           next=0;
           else
            {
                
                next=flowerbed[i+1];
            }
            if(flowerbed[i]==0&&before==0&&next==0)
            {
                flowerbed[i]=1;
                n--;

            }
            before=flowerbed[i];

           if(n<=0)
           return true;
        }
        return n<=0;
    }
}