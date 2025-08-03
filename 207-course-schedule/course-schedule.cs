public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int,List<int>> dict=new();
        int[] incoming=new int[numCourses];
        foreach(var item in prerequisites)
        {
            int from=item[1];
            int to=item[0];
            incoming[to]++;
            if(!dict.ContainsKey(from))
            dict[from]=new List<int>();
            dict[from].Add(to);

        }
        Queue<int> que=new();
        for(int i=0;i<numCourses;i++)
        {
            if(incoming[i]==0)
            que.Enqueue(i);


        }
        int count=0;
        while(que.Count>0)
        {
            int item=que.Dequeue();
              count++;
            if(!dict.ContainsKey(item))
            continue;
          
            foreach(var ngb in dict[item])
            {
                incoming[ngb]--;
                if(incoming[ngb]==0)
                que.Enqueue(ngb);

            }
        }
        if(count==numCourses)
        return true;
        return false;
        
    }
}