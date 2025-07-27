public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals==null)
        return null;
        if(intervals.Length<=1)
        return intervals;
        List<int[]> result=new();

        //sort according to start 
        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));
        result.Add(new int[2]{intervals[0][0],intervals[0][1]});
        for(int i=1;i<intervals.Length;i++)
        {
            int x=result.Count-1;
            int firststart=result[x][0];
            int firstend=result[x][1];
            int secondstart=intervals[i][0];
            int secondend=intervals[i][1];   
             
             //discrete
             if(firstend<secondstart)
             {
                result.Add(new int[2]{secondstart,secondend});
             }
             else if( secondstart<=firstend)
             {
                if(secondend<=firstend) //fully overlap
                {
                    continue;

                }
                else
                { //halfoverlap, end points change
                    result[x][1]=secondend;
                    
                }
             }
        }

        return result.ToArray();

        
    }
}