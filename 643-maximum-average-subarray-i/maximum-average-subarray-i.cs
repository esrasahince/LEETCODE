public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int result=int.MinValue;
        Queue<int> que=new();
        int sum=0;
        for(int i=0;i<nums.Length;i++)
        {

            if(que.Count<k)
            {
                sum+=nums[i];
                que.Enqueue(nums[i]);
                if(que.Count==k)
                {
                result=Math.Max(result,sum);
                }

            }
            else 
            {
                sum-=que.Dequeue();
                sum+=nums[i];
                que.Enqueue(nums[i]);
                result=Math.Max(result,sum);


            }
        }
        return (double)result/k;
        
    }
}