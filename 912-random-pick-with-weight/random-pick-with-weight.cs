public class Solution {
    int[] prefixsum=null;

    public Solution(int[] w) {
             //Örnek 1,4,3,5 olsun toplam 13 olur. 13 de herkes kendi payını alsın
        // 0,1,1,1,1,2,2,2,3,3,3, 3, 3--- hangi sayının denk geldiği
        // 0,1,2,3,4,5,6,7,8,9,10,11,12 indexler
        //bunu bu sekilde tutmak yerine her bir sayının bitiş noktasını tutarız
        // 1,5,8,13 seklinde peki 5 numaralı sayı secilirse bu neye denk gelir
        //bu noktada binary search devreye girer

       prefixsum=new int[w.Length];
        prefixsum[0]=w[0];
        for(int i=1;i<w.Length;i++)
        {
            prefixsum[i]=w[i]+prefixsum[i-1];

        }
        
    }
    
    public int PickIndex() {
        Random r=new Random();
        int totalsum=prefixsum[^1];
        int rand=r.Next(1,totalsum+1);
        return FindIndex(rand);
    
        
    }
    public int FindIndex(int target)
    {
        int left=0;
        int right=prefixsum.Length-1;
        while(left<right)
        {
            int middle=left+(right-left)/2;
            if(prefixsum[middle]<target)
            {
                left=middle+1;
            }
            else
            {
                right=middle;
            }
        }
        return left;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */