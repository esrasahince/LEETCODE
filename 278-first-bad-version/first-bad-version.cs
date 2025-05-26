/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {

        //elimizde n tane versiyon var. 
        // bir yerden sonra işler karışmış.
        //işlerin  İLK NEREDE karıştığını bulmaya çalışıyoruz.
        //problemi log n zamanda çözmemiz gerekiyor

        int left=1;
        int right=n;
        while(left<right)
        {
            int middle=left+(right-left)/2;
            if(IsBadVersion(middle))
            right=middle;
            else 
            left=middle+1;
        }
        return left;
        
    }
}