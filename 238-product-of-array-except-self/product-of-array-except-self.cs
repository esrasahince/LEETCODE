public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        List<int> prefix=new();
        int prev=1;

        for(int i=0;i<nums.Length;i++)
        {
            prev=prev*nums[i];
            prefix.Add(prev);
        }
        prev=1;
        int prod=1;
        for(int i=nums.Length-1;i>=0;i--)
        {
        
           if(i==0)
           {
            prefix[i]=prev;

           }
           else
           {
            prefix[i]=prefix[i-1]*prev;
            prev=nums[i]*prev;
           }


        }
        return prefix.ToArray();
    }
}