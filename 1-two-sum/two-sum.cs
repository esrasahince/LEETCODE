public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> itemdic=new();
        for(int i=0;i<nums.Length;i++)
        {
            int goal=target-nums[i];
            if(itemdic.ContainsKey(goal))
            return new int[2]{itemdic[goal],i};
            itemdic[nums[i]]=i;
        }
        return Array.Empty<int>();
    }
}