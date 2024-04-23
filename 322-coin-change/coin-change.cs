public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount==0)
        return 0;
        int coincount=0;
        int remain=0;
        int[] total=new int[amount+1];
        Array.Fill(total,amount+1);
        total[0]=0;
        
        for(int i=1;i<amount+1;i++)
        {
            foreach(int coin in coins)
            {
              if(i>=coin)
              {
                total[i] = Math.Min(total[i], 1 + total[i - coin]);
              }   
            }
            
        }
        return total[total.Length-1]==amount+1?-1:total[total.Length-1];
    }
}