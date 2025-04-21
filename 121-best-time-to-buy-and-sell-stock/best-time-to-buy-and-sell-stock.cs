public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length==0)
        return 0;
        //burada sadece bir tane transaction hakkın var
        //dolayısı ile min ve max elemanları max minden sonra gelecek şekilde ayarlamamız gerekiyor

        int min=int.MaxValue;
        int maxprofit=0;
        for(int i=0;i<prices.Length;i++)
        {
            if(prices[i]<min)
            {
                min=prices[i];
            }
            else
            {
                maxprofit=Math.Max(maxprofit,prices[i]-min);
            }
        }
        return maxprofit;
        
    }
}