public class Solution {
    public int ClimbStairs(int n) {

       


       
        return BottomUp(n);
        
    }

    public int BottomUp(int n)
    {
        //TABULARATION
         int[] target=new int[n+1];

         //BASE CASES
            target[n]=1;
            target[n-1]=1;

         //FOR LOOP
         for(int i=n-2;i>=0;i--)
         {
            target[i]=target[i+1]+target[i+2];

         }
         return target[0];

    }


}