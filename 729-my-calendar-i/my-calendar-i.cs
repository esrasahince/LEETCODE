public class MyCalendar {
     SortedDictionary<int,int> calendar=null;

    public MyCalendar() {
        this.calendar=new();
        
    }
    
    public bool Book(int startTime, int endTime) {
        if(this.calendar.Count==0)
        {
        this.calendar[startTime]=endTime;
        return true;
        }
        foreach(var item in this.calendar)
        {
            if(startTime<item.Value&&endTime>item.Key)
            return false;
        }
        this.calendar[startTime]=endTime;
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(startTime,endTime);
 */