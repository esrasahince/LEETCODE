public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums==null)
        return 0;
        if(nums.Length==1)
        return nums[0];
        //MANTIK ŞU şekilde
        //yeni ekleyeceğin eleman o anki toplamı kötü etkiliyor ise
        //sıfırdan o elamandan başlıyorsun
        //yani 2,3,-4
        //2 den başladın 3 ekledin. toplam 5 oldu.
        //-4 ekledin 5-4=1 toplam düştü bu sefer -4 ü eklemekten vazgeçip -4 ilk eleman gibi yapıyorsun
        // MaxSum kısmı herzaman en yüksek elemanı tuttuğu için nerde bitirdiğinin bir önemi yok. O maximumu alıp
        //işi sonuca ulaştırıyor
        int currentsum=nums[0];
        int maxsum=nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            currentsum=Math.Max(nums[i],currentsum+nums[i]);
            //elemanı ekleyip ilerleyim mi yoksa sıfırdan mı başlayım toplamaya
            maxsum=Math.Max(currentsum,maxsum);
            //benim nerden başladığı nerden bittiği ile ilgim yok
            //en yüksek hangisi onu soyle

        }
        return maxsum;
        
    }
}