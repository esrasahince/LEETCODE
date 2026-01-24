public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] pre=new int[nums.Length];
        int[] post=new int[nums.Length];
        pre[0]=nums[0];
        post[post.Length-1]=nums[nums.Length-1];
        for(int i=1;i<nums.Length;i++)
        {
            
            pre[i]=nums[i]*pre[i-1];

        }
         for(int i=nums.Length-2;i>=0;i--)
        {
            post[i]=nums[i]*post[i+1];
        }
         for(int i=0;i<nums.Length;i++)
        {
            if(i==0)
            nums[i]=post[1];
            else if(i==nums.Length-1)
            nums[i]=pre[i-1];
            else

            if(i>0)
            {
                nums[i]=pre[i-1]*post[i+1];
            }
        }

        return nums;
    }
}