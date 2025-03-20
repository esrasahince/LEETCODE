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
        int returnval=-1;
        while(stack.Count>0)
        {
            queue.Push(stack.Pop());
        }
        if(queue.Count>0)
        returnval=queue.Pop();
        while(queue.Count>0)
        {
            stack.Push(queue.Pop());
        }
       
       return returnval;
        
    }
    
    public int Peek() {
        int returnval=-1;
        while(stack.Count>0)
        {
            queue.Push(stack.Pop());
        }
        if(queue.Count>0)
        returnval=queue.Peek();
         while(queue.Count>0)
        {
            stack.Push(queue.Pop());
        }
       return returnval;
        
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