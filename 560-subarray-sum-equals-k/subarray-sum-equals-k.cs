public class Solution {
    public int SubarraySum(int[] nums, int k) {

        // prefix[i]-prefix[j-1]=target
        Dictionary<int,int> dict=new();
        int sum=0;
        int count=0;
        for(int i=0;i<nums.Length;i++)
        {
            sum+=nums[i];
            if(sum==k)
            {
                count++;
            }
            int remain=sum-k;
            if(dict.ContainsKey(remain))
            {
                count+=dict[remain];
            }
            if(dict.ContainsKey(sum))
             dict[sum]++;
            else
             dict[sum]=1;

        }
        return count;
    }
}