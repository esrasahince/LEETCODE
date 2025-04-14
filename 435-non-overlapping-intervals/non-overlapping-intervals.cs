public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        

        intervals=intervals.OrderBy(x=>x[1]).ThenBy(x=>x[0]).ToArray();
        int result=0;
        int last=intervals[0][1];
        for(int i=1;i<intervals.Length;i++)
        {
        if(intervals[i][0]<last)
        {
            result++;
            continue;

        }
        last=intervals[i][1];
        }
        return result;
        
    }
}