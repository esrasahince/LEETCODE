public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> dict=new();
       
        dict[0]=1;
        int current=0;
        int result=0;
       
        for(int i=0;i<nums.Length;i++)
        {
            current=nums[i]+current;
          
            int remain=current-k;
            if(dict.ContainsKey(remain)){
              result+=dict[remain];
            }
            if(dict.ContainsKey(current))
            dict[current]++;
            else
            dict[current]=1;

        }
        return result;
        
    }
}