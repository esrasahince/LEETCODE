public class Solution {
    public int HammingWeight(int n) {
        string binary=Convert.ToString(n,2);
        int count=0;
        while(n!=0)
        {
            n=n&(n-1); //en sağdaki 1 i 0 yapar
            count++;
        }
        return count;
        
    }
}