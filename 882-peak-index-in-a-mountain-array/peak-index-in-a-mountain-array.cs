public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        if(arr==null||arr.Length==0)
        return 0;
        int left=0;
        int right=arr.Length-1;
        while(left<right)
        {
            int middle=left+(right-left)/2;
          
            if(arr[middle]<arr[middle+1])
            {
                left=middle+1;
            }
            else
            {
                right=middle;
            }
        }
        return left;
        
    }
}