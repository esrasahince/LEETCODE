public class Solution {
    //bu soruda birden fazla zirve olabilir herhangi birini bulmamız isteniyor. 
    //kosulun bir tarafını sagladıgımızda diğer tarafı ignore ediyoruz. 
    public int FindPeakElement(int[] nums) {
//Dizi sıralı olmasa da, her zaman bir zirveye doğru tırmanabileceğimiz garantisi 
//(komşularla kıyaslama ve hayali eksi sonsuz uçlar sayesinde) Binary Search'i mümkün kılar.
      int left=0;
      int right=nums.Length-1;
      while(left+1<right) //döngüyü left ve right arasında yalnızca iki eleman kaldığında sonlandırır.
      {
        int middle=left+(right-left)/2;
        if(nums[middle]<nums[middle+1]) //middle elemanı, sağındaki elemandan küçük. Bu durumda, middle bir zirve olamaz.
        left=middle;
        else  //middle elemanı, sağındaki elemandan büyük.middle zirve olabilir.
        right=middle;
      }
      // (left + 1 == right), döngü biter.
          return nums[left] > nums[right] ? left : right;
 
        
    }
}