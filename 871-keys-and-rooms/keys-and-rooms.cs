public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        if(rooms==null||rooms.Count==0)
        return true;
        return BFS();
        
        bool BFS()
        {
          HashSet<int> visited=new();
          Queue<int> que=new();
          que.Enqueue(0);
          visited.Add(0);
          while(que.Count>0)
          {
            int visit=que.Dequeue();
            if(visit>=rooms.Count||visit<0)
            continue;
           
          
            foreach(var item in rooms[visit])
            {
                if(!visited.Contains(item))
                que.Enqueue(item);
                 visited.Add(item);
            }
          }
          if(visited.Count==rooms.Count)
          return true;
          else return false;

        }
        
    }
}