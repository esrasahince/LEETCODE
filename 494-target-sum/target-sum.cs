public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {

        //Elemanın başına + ya da - koyarak target suma ulaşmak istiyoruz
        //kaç farklı şekilde yapabiliz yani count soruyor 

        //1. Count sorduğu için output int olmalı
        //2. inputlar-> nums,index,currentsum,memo  burada değişenler currentsum ve index 
        //bu nedenle tüm senaryoyu bunlara göre yapacağız.
        //BASE KOŞUL
        //dizide hiç eleman kalmadığında yani index<0 iken
        //currentsum da sıfırsa istediğimiz duruma ulaşmışız demektir count 1 olmalı
        //currentsum sıfırdan farklı ise istediğimiz koşula ulaşamadık. 0 dön
        //CHOICE DIAGRAM
        //Burada her bir item için ekle yada çıkar mantığı var.
        //peki ekleme çıkarma için bir önkoşul var mı? currentsumdan küçükse büyükse ekle gibi.
        //HAYIR elemanları sıralı bir şekilde yalnızca + ve - ile yönetiyoruz. tamamen çıkarmıyoruz.

        //MEMORIZATION
        //değişen elemanlar currentsum ve index olduğu için bunları memorize ediyoruz
        Dictionary<(int,int),int> memo=new();
        return TopDown(nums,target,nums.Length-1,memo);

        
    }
    public int TopDown(int[] nums,int currentsum,int index, Dictionary<(int,int),int> memo)
    {
        //BASE KOŞUL
        if(index<0)
        {
            return currentsum==0?1:0;
        }
        if(memo.ContainsKey((currentsum,index)))
        return memo[(currentsum,index)];

        //+ koşulu
        int plus=TopDown(nums,currentsum+nums[index],index-1,memo);
        int minus=TopDown(nums,currentsum-nums[index],index-1,memo);
        memo[(currentsum,index)]=plus+minus;

        return plus+minus;

    }
}