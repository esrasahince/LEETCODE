public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {

	if(nums==null||nums.Length==0)
	return 0;
	int result=int.MaxValue;
	int sum=0;
	int windowbegin=0;
	bool check=false;
	
    for(int i=0;i<nums.Length;i++)
	{
	  sum+=nums[i];
	  
	   while (sum >= target) {
                result = Math.Min(result, i - windowbegin + 1);
                sum -= nums[windowbegin];
                windowbegin++;
            }
    }
    
	
	return result==int.MaxValue?0:result;
    }}
        
  