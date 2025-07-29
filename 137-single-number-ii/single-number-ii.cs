public class Solution {
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        // her bir sayı 32 bit ile gösteriliyor
        for (int i = 0; i < 32; i++)
        {
            int count = 0;
            foreach (int item in nums)
            {
                int mask = 1 << (31 - i);
                if((item & mask)==mask)
                {count++;}

            }
            if (count % 3 != 0)
            {
                result = result | 1 << (31 - i);

            }

        }
        return result;

        
    }
}