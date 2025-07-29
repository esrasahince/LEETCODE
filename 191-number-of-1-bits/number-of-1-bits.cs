public class Solution {
    public int HammingWeight(int n) {

        int count=0;
        while(n!=0)
        {
            count+=n&1; //en sağdaki bit 1 ise 1 döner. countı artırır.
            n=n>>1; //sağa kaydırıp tüm bitleri kontrol ederiz Log(n) zaman alır. 
        }
        return count;
        
    }
}