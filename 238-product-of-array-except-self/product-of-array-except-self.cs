public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int[] prefix=new int[nums.Length];
        int[] suffix=new int[nums.Length];
        prefix[0]=nums[0];
       
        for(int i=1;i<nums.Length;i++)
        {
            prefix[i]=prefix[i-1]*nums[i];
        
        }
        int post=1;
         for(int i=nums.Length-1;i>0;i--)
        {
            prefix[i]=post*prefix[i-1];
            post=post*nums[i];


        }
        prefix[0]=post;
        return prefix;
    }
 
}