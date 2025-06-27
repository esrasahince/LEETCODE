public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        if(arr==null||arr.Length<1)
        return 0;

        int left=0;
        int right=arr.Length-1;
        while(left+1<right)
        {
            int middle=left+(right-left)/2;
            //24,69,100,99,79,78,67,36,26,19]
            //middle 79 , 67
            if(arr[middle]>arr[middle+1]) // left 79, right 67
            {
                right=middle; 
            }
            else
            {
                left=middle; //right 1
            }
        }
        //left+1=right oldugunda dongu biter.
        //iki tane adayımız var. left ve right
        return arr[left]>arr[right]?left:right;
        
    }
}