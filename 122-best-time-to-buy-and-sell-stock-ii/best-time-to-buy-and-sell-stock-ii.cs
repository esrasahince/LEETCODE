public class Solution {
    public int MaxProfit(int[] prices) {

        if(prices.Length==0)
        return 0;
        int result=0;

        for(int i=1;i<prices.Length;i++)
        {
            if(prices[i]>prices[i-1])
            {
                
                result+=(prices[i]-prices[i-1]);
            

            }
        }
        return result;
    }
}