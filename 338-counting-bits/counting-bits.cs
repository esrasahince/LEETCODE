public class Solution {
    public int[] CountBits(int n) {
        int[] result=new int[n+1];
        if(n>=1) result[1]=1;
        for(int i=2;i<n+1;i++)
        {
            result[i]=result[i>>1]+(i&1);
        }

    return result;
        
    }

 
}