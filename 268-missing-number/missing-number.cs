public class Solution {
    public int MissingNumber(int[] nums) {
        //XOR mantıgı çiftleri 0 yapar. tek olan eleman kalır
        //burada index numaraları ile elemanları xor yaparsak
        //geriye tek olan kalır
        //AMA DIKKAT: index sayısı arr uzunlugu kadar degil bir fazla
        //zaten 1 eleman eksik. o nedenle 1 fazla

        int result=0;
        for(int i=0;i<=nums.Length;i++)
        {
            result^=i;
        }
        //indexleri xor yaptık. şimdi sıra elemanları bunla xor yapmakta
        foreach(int item in nums)
        {
            result^=item;
        }
        return result;
        
    }
}