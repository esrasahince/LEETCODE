public class MinStack {
    List<List<int>> stack=null;
    int min=int.MaxValue;
    int index=0;


    public MinStack() {
     this.stack=new List<List<int>>();
        
    }
    
    public void Push(int val) {
        if(val<min)
        {
            min=val;
        }
        this.stack.Add(new List<int>{val,min});
        
    }
    
    public void Pop() {
        
      if (stack.Count > 0)
{
    stack.RemoveAt(stack.Count - 1);
}
if(stack.Count>0)
{min= this.stack[stack.Count-1][1];
}
else{
    min=int.MaxValue;
}
        
    
       
        
    }
    
    public int Top() {
        return this.stack[stack.Count-1][0];
        
    }
    
    public int GetMin() {
           return this.stack[stack.Count-1][1];
        
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */