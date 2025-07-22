public class LRUCache {
    LinkedList<(int,int)> list=null;
    int capacity=0;
    Dictionary<int,LinkedListNode<(int,int)>> dict=null;

    public LRUCache(int capacity) {
        this.list=new();
        this.dict=new();
        this.capacity=capacity;
        
    }
    
    public int Get(int key) {
        if(!dict.ContainsKey(key))
        return -1;
        LinkedListNode<(int,int)> node=dict[key];
        list.Remove(node);
        list.AddLast(node);
        return node.Value.Item2;
        
    }
    
    public void Put(int key, int value) {
        if(dict.ContainsKey(key))
        {
            LinkedListNode<(int,int)> item=dict[key];
            list.Remove(item);
                dict.Remove(key); 
            
        }
        if(dict.Count>=capacity)
        {
            LinkedListNode<(int,int)> first=list.First;
            list.RemoveFirst();
            dict.Remove(first.Value.Item1);
        }
      
        list.AddLast((key,value));
        LinkedListNode<(int,int)> last=list.Last;
        dict[key]=last;
        
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */