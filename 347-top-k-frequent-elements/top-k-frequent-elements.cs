public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict=new();
        foreach(int item in nums)
        {
            if(!dict.ContainsKey(item))
            dict[item]=1;
            else
            dict[item]=dict[item]+1;
        }
        //Comparer<int> comp=Comparer<int>.Create((a,b)=>b.CompareTo(a));
        PriorityQueue<int,int> que=new PriorityQueue<int,int>();
        foreach(var item in dict)
        {
            que.Enqueue(item.Key,item.Value);
            if(que.Count>k)
            {
                que.Dequeue();
            }

        }
        int[] result=new int[k];
        for(int i=0;i<k;i++)
        {
            result[i]=que.Dequeue();
        }

        return result;
    }
}