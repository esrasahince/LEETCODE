public class Solution {
    public int[] SortArray(int[] nums) {
        PriorityQueue<int,int> que=new();
        foreach(int item in nums)
        {
            que.Enqueue(item,item);
        }
        int i=0;
        while(que.Count>0&&i<nums.Length)
        {
            nums[i]=que.Dequeue();
            i++;
        }
        return nums;
        
    }
}