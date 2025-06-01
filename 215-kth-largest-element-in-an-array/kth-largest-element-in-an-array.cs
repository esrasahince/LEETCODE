public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        //largest elementi soruosa minheap kullanıcaz

        PriorityQueue<int,int> que=new();
        for(int j=0;j<k;j++)
        {
            que.Enqueue(nums[j],nums[j]);
        }
     
        if(nums.Length<=k)
        {
            return que.Dequeue();
        }
        int i=k;
        while(i<nums.Length)
        {
            que.Enqueue(nums[i],nums[i]);
            que.Dequeue();
            i++;
   
        }
        return que.Dequeue();
        
    }
}