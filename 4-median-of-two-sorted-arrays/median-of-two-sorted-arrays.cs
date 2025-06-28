public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
      //nums1 kücük olan array olarak kabul ettik. 
       if(nums1.Length>nums2.Length)
       return FindMedianSortedArrays(nums2,nums1);
       
       int totalsize=nums1.Length+nums2.Length;
       int partionsize=(nums1.Length+nums2.Length+1)/2;

       //nums1 üzerinde binary search yapacakmışız gibi düşün
       int left=0;
       int right=nums1.Length; //dikkat -1 değil
       while(left<=right)
       {

        int i=(left+right)/2; //X de baslangıcta kac eleman olacagı
        int j=partionsize-i;

      int leftx = (i == 0) ? int.MinValue : nums1[i - 1];
     int rightx = (i == nums1.Length) ? int.MaxValue : nums1[i];
            int lefty = (j == 0) ? int.MinValue : nums2[j - 1];
            int righty = (j == nums2.Length) ? int.MaxValue : nums2[j];

        if(leftx<=righty&&lefty<=rightx)
        {
            if(totalsize%2==0)
             return (double)(Math.Max(leftx,lefty)+Math.Min(rightx,righty))/2;
            else
             return (double)Math.Max(leftx,lefty); 

        }
        else if(leftx>righty) //üstü kücült
        {
          right=i-1;
        }
        else //üstü büyüt
        {
            left=i+1;

        }

       }
       return 0;
        
    }
}