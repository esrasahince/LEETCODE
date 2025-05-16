public class Solution {
    public bool CanPartition(int[] nums) {

        //Input: nums = [1,5,11,5] Output: true
        //The array can be partitioned as [1, 5, 5] and [11].

        //output boolean
        //choices for each item add first group, or add second group not include at the same time
        //input--> index sum1, sum2
        //index<0 if(sum1==sum2) true else false
        Dictionary<(int,int),bool> memo=new();
        int sum=0;
        for(int i=0;i<nums.Length;i++)
        {
            sum+=nums[i];

        }
        if(sum%2!=0)
        return false;
        
        return TopDown(nums,nums.Length-1,sum/2,memo);

        
    }
    public bool TopDown(int[] nums,int index,int sum1, Dictionary<(int,int),bool> memo)
    {
        if(index<0)
        {
            return sum1==0?true:false;
        }
        if(memo.ContainsKey((index,sum1)))
        {
            return memo[(index,sum1)];
        }

        memo[(index,sum1)]=TopDown(nums,index-1,sum1-nums[index],memo)||TopDown(nums,index-1,sum1,memo);
        return memo[(index,sum1)];
    }
}