public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        Comparer<double> comp=Comparer<double>.Create((a,b)=>b.CompareTo(a));
        PriorityQueue<int[],double> que=new PriorityQueue<int[],double>(comp);
        foreach(var item in points)
        {
            double dist=Math.Sqrt(item[0]*item[0]+item[1]*item[1]);
            que.Enqueue(item,dist);
            if(que.Count>k)
            {
                que.Dequeue();
            }
        }
        int[][] result=new int[k][];
        for(int i=0;i<k;i++)
        {
            result[i]=que.Dequeue();
        }
        return result;
    }
}