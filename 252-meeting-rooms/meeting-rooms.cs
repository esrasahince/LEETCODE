public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        if(intervals.Length==0||intervals==null)
        return true;
        
        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));
        for(int i=1;i<intervals.Length;i++)
        {
            if(intervals[i][0]<intervals[i-1][1])
            return false;
        }
        return true;
    }
}