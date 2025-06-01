public class MedianFinder {

    PriorityQueue<int,int> minheap=null;
   
    PriorityQueue<int,int> maxheap=null;

    public MedianFinder() {
        minheap=new();
    Comparer<int> comp=Comparer<int>.Create((a,b)=>b.CompareTo(a));
    maxheap=new PriorityQueue<int,int>(comp);
        
    }
    
    public void AddNum(int num) {
      // Always add to maxHeap first
        maxheap.Enqueue(num, num);
        
        // Move the largest from maxHeap to minHeap to maintain order
        int valueToMove = maxheap.Dequeue();
        minheap.Enqueue(valueToMove, valueToMove); // ✅ Use the dequeued value, not Peek()
        
        // Balance the heaps - maxHeap can have at most 1 more element than minHeap
        if (maxheap.Count < minheap.Count) 
        {
            int valueToMoveBack = minheap.Dequeue();
            maxheap.Enqueue(valueToMoveBack, valueToMoveBack); // ✅ Use the dequeued value
        }
        
        
    }
    
    public double FindMedian() {
     
        if(maxheap.Count>0&&maxheap.Count>minheap.Count)
        {
            return (double)maxheap.Peek();
     
        }
        else
        {
            return (double)(maxheap.Peek()+minheap.Peek())/2;
        }

        
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */