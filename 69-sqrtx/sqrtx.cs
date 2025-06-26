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
            else if( x>(long)middle*middle)
            left=middle+1;
            else
            right=middle-1;
      }
      //right< left oldugunda sorgu bitti.
      //right-->target-->left şeklinde
      return right;
       
        
    }
}