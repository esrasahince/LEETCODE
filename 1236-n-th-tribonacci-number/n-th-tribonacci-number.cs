public class Solution {
    public int Tribonacci(int n) {
        
        int[] last=new int[3];
        
        //BaseCases
        last[0]=0;
        last[1]=0;
        last[2]=1;
        if(n<2)
        return last[n+1];

        for(int i=3;i<=n+1;i++)
        {
            var result=last[0]+last[1]+last[2];
            last[0]=last[1];
            last[1]=last[2];
            last[2]=result;
        }
        return last[2];
    }
}