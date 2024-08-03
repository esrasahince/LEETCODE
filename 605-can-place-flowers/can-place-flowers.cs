public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
         if (flowerbed.Length == 1) {
            if (flowerbed[0] == 0) {
                return n <= 1;
            } else {
                return n == 0;
            }
        }
        

        for(int i=0;i<flowerbed.Length;i++)
        {
            if(flowerbed[i]==0)
            {
                if((i==0&&flowerbed[i+1]==0)||(i==flowerbed.Length-1&&flowerbed[flowerbed.Length-2]==0))
                {
                     flowerbed[i]=1;
                      n--;

                }
               
                
               else if (i > 0 && i < flowerbed.Length - 1 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0) {
                    flowerbed[i] = 1;
                    n--;

                }
            }
            if(n<=0)
            return true;
        }
        return n<=0;
    }
}