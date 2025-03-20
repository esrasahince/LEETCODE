public class MyQueue {
      Stack<int> stack;
        Stack<int> queue;

    public MyQueue() {
       this.stack=new();
     this.queue=new();
        
    }
    
    public void Push(int x) {
        stack.Push(x);
        
    }
    
    public int Pop() {
      
        if(queue.Count>0)
        return queue.Pop();
        else
        {
        while(stack.Count>0)
        {
            queue.Push(stack.Pop());
        }
        if(queue.Count>0)
        return queue.Pop();
        }
  
       return -1;
        
    }
    
    public int Peek() {
       if(queue.Count>0)
        return queue.Peek();
        else
        {
        while(stack.Count>0)
        {
            queue.Push(stack.Pop());
        }
        if(queue.Count>0)
        return queue.Peek();
        }
  
       return -1;
        
        
    }
    
    public bool Empty() {
           while(stack.Count>0)
        {
            queue.Push(stack.Pop());
        }
        return queue.Count>0?false:true;
        
        
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */