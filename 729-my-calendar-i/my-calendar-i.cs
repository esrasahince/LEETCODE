public class MyCalendar {
     SortedList<int,int> calendar=null;

    public MyCalendar() {
        this.calendar=new();
        
    }
    
    public bool Book(int startTime, int endTime) {
        if(this.calendar.Count==0)
        {
        this.calendar.Add(startTime,endTime);
        return true;
        }
        List<int> starttimes=calendar.Keys.ToList();
        List<int> endtimes=calendar.Values.ToList();

        //kendinden hemen sonra baslayacak etkinliği bulma
        int upperind=starttimes.BinarySearch(startTime);
        if(upperind<0)
        {
            upperind=~upperind;
        }
      
        if(upperind>0)
        {
           
            //kendinden hemen önce biten etkinlik upperboundind-1 de yer alır
            
            if(endTime>starttimes[upperind-1]&&startTime<endtimes[upperind-1])
            return false;
        }
        if(upperind<calendar.Count)
        {
             if(endTime>starttimes[upperind]&&startTime<endtimes[upperind])
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