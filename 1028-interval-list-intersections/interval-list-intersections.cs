public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {

       int[][] final= firstList.Concat(secondList).ToArray();
       Array.Sort(final,(a,b)=>{
        int first=a[0].CompareTo(b[0]);
        if(first!=0) return first;
        int second=a[1].CompareTo(b[1]);
          return second;});
       List<int[]> result=new();
       int firststart=final[0][0];
       int firstend=final[0][1];
       for(int i=1;i<final.Length;i++)
       {
         int secondstart=final[i][0];
         int secondend=final[i][1];
         if(firststart==secondstart)
         {
            result.Add(new int[2]{firststart, Math.Min(firstend,secondend)});
         }
         else if(secondstart<=firstend)
         {
            int s=Math.Min(secondstart,firstend);
            int e=Math.Min(secondend,firstend);
            result.Add(new int[2]{s,e});
         }
         firststart=secondstart;
         firstend=Math.Max(firstend,secondend);


       }
       return result.ToArray();

        
    }
}