public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        //Search space Max eleman ile totalweight arasında
        //biri artarken diğeri azalır. Monotonicity
        //capacity.          day
         //total weight.      1
          //totalweight-1.     2
        int totalweight=weights.Sum();
        int left=weights.Max();
        int right=totalweight;
        while(left<right)
        {
            int middle=left+(right-left)/2;
            int result=CalculateDay(weights,middle);
            if(result>days)
            {
                left=middle+1;
            }
            else
            right=middle;

        }
        return right;


    }
    public int CalculateDay(int[] weight, int capacity)
    { int current=0;
       int result=1;
        foreach(int w in weight)
        {
            if(current+w>capacity)
            {
                result++;
                current=w;
             
            }
            else
             current+=w;

        }
      
        return result;
    }
}