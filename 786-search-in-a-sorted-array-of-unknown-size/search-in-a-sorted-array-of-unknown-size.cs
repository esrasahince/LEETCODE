/**
 * // This is ArrayReader's API interface.
 * // You should not implement it, or speculate about its implementation
 * class ArrayReader {
 *     public int Get(int index) {}
 * }
 */

class Solution {
    public int Search(ArrayReader reader, int target) {

       int left=0;
       int last=Math.Abs(target-reader.get(0));

        while(reader.get(last)==Math.Pow(2,31)-1)
        {
            last--;
        }
        while(left<=last)
        {
            int middle=left+(last-left)/2;
            int item=reader.get(middle);
            if(item==target)
            return middle;
            if(item<target)
            left=middle+1;
            else
            last=middle-1;
        }
        return -1;
        
    }
}