public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int totalweight=0;
        
        foreach(int w in weights)
        {
            totalweight+=w;
        }

        //Search space 1-totalweight
        //capacity.          day
         //total weight.      1
          //totalweight-1.     2
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
       int result=0;
        for(int i=0;i<weight.Length;i++)
        {
            if(current<capacity&&weight[i]<=capacity)
            {
                current+=weight[i];
                if(current>capacity)
                {
                    result++;
                    current=weight[i];
                }

                else if(current==capacity)
                {
                    result++;
                    current=0;
                }
            }

        }
        if(current>0)
        result++;
        return result;
    }
}