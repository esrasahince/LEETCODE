public class Solution {
    public int MaxSubArrayLen(int[] nums, int k) {
        
        // bu prefix sum dictionary kümülatif olarak toplamları tutuyor
        //yani [1,2,3,4] dizisi için prefix sum [0:1, 3:1,6:2,10:3] gibi
        Dictionary<int,int> prefixsum=new();

        int currentsum=0;
        int maxitemcount=0;

        //şimdi for dongusu ile sırasıyla gezicez ve currentsum k ya ulasacak mı diye bakıcaz

        for(int i=0;i<nums.Length;i++)
        {
            currentsum+=nums[i];
            if(currentsum==k)
            {
                maxitemcount=Math.Max(maxitemcount,i+1);
            }
            //current sum k dan büyükse aradaki farka hangi noktada ulasmısız. yani curren 10 olsun k ise 3
            //10-3=7 diyelimki bu toplama 2. indexte ulasıldı. yani prefixsum[7]=2. 
            //ozaman bu demektirki i ve 2 arasındaki rakamların toplamı k ediyor. Dolayısıyla toplam eleman sayısı
            //i-2 olur.
            
            if(prefixsum.ContainsKey(currentsum-k))
            {
               maxitemcount=Math.Max(maxitemcount,i-prefixsum[currentsum-k]);
            }
            
            if(!prefixsum.ContainsKey(currentsum))
            {
                prefixsum[currentsum]=i;
            }

        }
        return maxitemcount;
       
        
    }
}