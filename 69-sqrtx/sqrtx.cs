public class Solution {
    public int MySqrt(int x) {
        if(x==0|| x==1)
        return x;
    
        

        int left=0;
        int right=x/2;
      while(left<=right)
      {
            int middle=left+(right-left)/2;
            if(x==(long)middle*middle)
            return middle;
            else if( x<(long)middle*middle)
            right=middle-1;
            else
            left=middle+1;
        }
        return right;
        
    }
}