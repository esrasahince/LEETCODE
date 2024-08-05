public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int result=Int32.MaxValue;
        Queue<int> que=new();
        int sum=0;
        for(int i=0;i<nums.Length;i++)
        {
        
                sum+=nums[i];
                que.Enqueue(nums[i]);
          
             
             while(sum>=target)
             {
                  result=Math.Min(result,que.Count);
                sum-=que.Dequeue();
             }
            
       

        }
        return result==Int32.MaxValue?0:result;
    }
}