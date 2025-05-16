public class Solution {
    public bool CanPartition(int[] nums) {

        //Input: nums = [1,5,11,5] Output: true
        //The array can be partitioned as [1, 5, 5] and [11].

        //output boolean
        //choices for each item add first group, or add second group not include at the same time
        //input--> index sum1, sum2
        //index<0 if(sum1==sum2) true else false
        Dictionary<(int,int,int),bool> memo=new();
        int sum=0;
        for(int i=0;i<nums.Length;i++)
        {
            sum+=nums[i];

        }
        if(sum%2!=0)
        return false;
        
        return TopDown(nums,nums.Length-1,0,0,memo);

        
    }
    public bool TopDown(int[] nums,int index,int sum1, int sum2,Dictionary<(int,int,int),bool> memo)
    {
        if(index<0)
        {
            return sum1==sum2?true:false;
        }
        if(memo.ContainsKey((index,sum1,sum2)))
        {
            return memo[(index,sum1,sum2)];
        }

        memo[(index,sum1,sum2)]=TopDown(nums,index-1,sum1+nums[index],sum2,memo)||TopDown(nums,index-1,sum1,sum2+nums[index],memo);
        return memo[(index,sum1,sum2)];
    }
}