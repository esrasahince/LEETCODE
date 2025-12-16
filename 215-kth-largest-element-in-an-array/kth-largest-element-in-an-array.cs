public class Solution {
    public int FindKthLargest(int[] nums, int k) {

        Comparer<int> comp=Comparer<int>.Create((a,b)=>b.CompareTo(a));

        PriorityQueue<int,int> que=new(comp);
        foreach(var item in nums)
        {
        
            que.Enqueue(item,item);
        }
        for(int i=1;i<k;i++)
        {
            que.Dequeue();
        }
      
        return que.Peek();
        
    }
}