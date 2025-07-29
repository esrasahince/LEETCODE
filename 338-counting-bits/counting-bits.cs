public class Solution {
    public int[] CountBits(int n) {
        int[] result=new int[n+1];
        if(n>=1) result[1]=1;
        for(int i=2;i<n+1;i++)
        {
            result[i]=Count(i);
        }

    return result;
        
    }

    public int Count (int n)
    {
        int count=0;
        while(n!=0)
        {
            n=n&(n-1);
            count++;
        }
        return count;
    }
}