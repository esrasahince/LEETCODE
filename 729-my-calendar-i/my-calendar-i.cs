public class MyCalendar {
List<List<int>> calendar=null;
    public MyCalendar() {
        this.calendar=new();
  
    }
    
    public bool Book(int startTime, int endTime) {
        if(this.calendar.Count==0)
        {
        this.calendar.Add(new List<int>(){startTime,endTime});
        return true;
        }
        
        for(int i=0;i<this.calendar.Count;i++)
        {  
           if(startTime<calendar[i][1]&&endTime>calendar[i][0])
           return false;
            
        }
        calendar.Add(new List<int>(){startTime,endTime});
        this.calendar=calendar.OrderBy(x=>x[0]).ToList();
        return true;
        
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(startTime,endTime);
 */