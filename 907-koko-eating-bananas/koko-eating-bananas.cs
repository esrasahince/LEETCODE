public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max=0;
        for(int i=0;i<piles.Length;i++)
        {
         max=Math.Max(max,piles[i]);
        }
        int left=1;
        int right=max;
        int middle=0;
        while(left<right)
        {
        middle=left+(right-left)/2;

        int total=Calculate(piles,middle);
        
        if(total>h)
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
    public int Calculate(int[] piles,int h)
    {
        int result=0;
        for(int i=0;i<piles.Length;i++)
        {
           result+=(int)Math.Ceiling(piles[i]/(double)h);
        }
        return result;
    }
}