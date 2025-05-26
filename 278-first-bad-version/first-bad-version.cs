/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {

        //elimizde n tane versiyon var. 
        // bir yerden sonra işler karışmış.
        //işlerin  İLK NEREDE karıştığını bulmaya çalışıyoruz.
        //problemi log n zamanda çözmemiz gerekiyor
    int left = 0;
    int right = n;
    int result = -1;

    while (left <= right) {
        int middle = left + (right - left) / 2;

        if (IsBadVersion(middle)) {
            result = middle;     // Eşleşme bulundu
            right = middle - 1;   // Sağda daha ileri bir eşleşme olabilir
        } else
            left = middle + 1;   // Sağ tarafa git
     
    }

    return result;
}
}