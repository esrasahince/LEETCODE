public class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        //num[j]==diff+num[i];
        //num[k]=2diff+num[i]

        //sonuc olarak num[i]=diff-num[j] ve num[i]==2diff-num[k] varmı die bakıcaz
        HashSet<int> set=new();
        int count=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(set.Contains(nums[i]-diff)&&set.Contains(nums[i]-2*diff))
            {
             
                count++;
            }
          
                set.Add(nums[i]);
            

        }
        return count;
        
    }
}