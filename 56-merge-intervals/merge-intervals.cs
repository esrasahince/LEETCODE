public class Solution {
    public int[][] Merge(int[][] intervals) {

        //x1,y1  x2,y2

        //sort result x1<=x2
        //if(x1==x2)=> x1, Max(y1,y2)
        //if(y1<=x2)=> x1, y2
         //else(y1>x2)=> x1, Max(y1,y2)


        if(intervals.Length==0)
        return intervals;

        List<int[]> result=new();

        Array.Sort(intervals,(a,b)=>a[0].CompareTo(b[0]));

        result.Add(new int[2]{intervals[0][0],intervals[0][1]});

        for(int i=1;i<intervals.Length;i++)
        {
            int len=result.Count-1;
            if(intervals[i][0]==result[len][0]|| result[len][1]>=intervals[i][0])
            {
                result[len][1]=Math.Max(result[len][1],intervals[i][1]);
            }
            else if(result[len][1]<intervals[i][0])
             result.Add(new int[2]{intervals[i][0],intervals[i][1]});
             
        }
        return result.ToArray();
        
    }
}